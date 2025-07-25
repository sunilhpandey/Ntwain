﻿using NTwain.Data;
using NTwain.Triplets;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NTwain
{
  // this file contains data source utilities

  partial class TwainAppSession
  {
    /// <summary>
    /// Gets all available sources.
    /// </summary>
    /// <returns></returns>
    public IEnumerable<TW_IDENTITY_LEGACY> GetSources()
    {
      var rc = DGControl.Identity.GetFirst(ref _appIdentity, out TW_IDENTITY_LEGACY ds);
      while (rc == TWRC.SUCCESS)
      {
        yield return ds;
        rc = DGControl.Identity.GetNext(ref _appIdentity, out ds);
      }
    }

    /// <summary>
    /// Shows the TWAIN source selection UI for setting the default source.
    /// Only included for completeness, not recommended for real app usage.
    /// </summary>
    public STS ShowUserSelect()
    {
      var rc = DGControl.Identity.UserSelect(ref _appIdentity, out TW_IDENTITY_LEGACY ds);
      if (rc == TWRC.SUCCESS)
      {
        _defaultDS = ds;
        try
        {
          DefaultSourceChanged?.Invoke(this, ds);
        }
        catch { }
      }
      return WrapInSTS(rc);
    }

    /// <summary>
    /// Loads and opens the specified data source.
    /// </summary>
    /// <param name="source"></param>
    public STS OpenSource(TW_IDENTITY_LEGACY source)
    {
      var rc = DGControl.Identity.OpenDS(ref _appIdentity, ref source);
      if (rc == TWRC.SUCCESS)
      {
        State = STATE.S4;
        RegisterCallback();
        Language.Set(source.Version.Language);
        CurrentSource = source;
      }
      return WrapInSTS(rc);
    }

    /// <summary>
    /// Closes the currently open data source.
    /// </summary>
    public STS CloseSource()
    {
      var rc = DGControl.Identity.CloseDS(ref _appIdentity, ref _currentDS);
      if (rc == TWRC.SUCCESS)
      {
        State = STATE.S3;
        CurrentSource = default;
      }
      return WrapInSTS(rc);
    }

    /// <summary>
    /// Sets the default data source.
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public STS SetDefaultSource(TW_IDENTITY_LEGACY source)
    {
      // this doesn't work on windows legacy twain_32.dll

      var rc = DGControl.Identity.Set(ref _appIdentity, ref source);
      if (rc == TWRC.SUCCESS)
      {
        _defaultDS = source;
        try
        {
          DefaultSourceChanged?.Invoke(this, source);
        }
        catch { }
      }
      return WrapInSTS(rc);
    }


    /// <summary>
    /// Enables the currently open source.
    /// </summary>
    /// <param name="showUI">Whether to show driver interface.</param>
    /// <param name="uiOnly">If true try to display only driver dialog (no capture). 
    /// Otherwise capturing will begin after this.</param>
    /// <returns></returns>
    public STS EnableSource(bool showUI, bool uiOnly)
    {
      if (_pumpThreadMarshaller == null) return EnableSourceReal(showUI, uiOnly);

      var sts = default(STS);
      _pumpThreadMarshaller.Send(_ =>
      {
        sts = EnableSourceReal(showUI, uiOnly);
      }, null);
      return sts;
    }

    private STS EnableSourceReal(bool showUI, bool uiOnly)
    {
      if (State > STATE.S4)
      {
        // already enabled :(
        // TODO: should bring it down?
      }
      _closeDsRequested = false;
      _userInterface = new TW_USERINTERFACE
      {
        ShowUI = (ushort)((showUI || uiOnly) ? 1 : 0),
        hParent = _hwnd,
      };
      var rc = uiOnly ?
        DGControl.UserInterface.EnableDSUIOnly(ref _appIdentity, ref _currentDS, ref _userInterface) :
        DGControl.UserInterface.EnableDS(ref _appIdentity, ref _currentDS, ref _userInterface);
      if (rc == TWRC.SUCCESS || (!uiOnly && !showUI && rc == TWRC.CHECKSTATUS))
      {
        State = STATE.S5;
      }
      else
      {
        _userInterface = default;
      }
      return WrapInSTS(rc);
    }

    /// <summary>
    /// Disables the currently enabled source.
    /// </summary>
    /// <returns></returns>
    public STS DisableSource()
    {
      if (_pumpThreadMarshaller == null) return DisableSourceReal();

      var sts = default(STS);
      _pumpThreadMarshaller.Send(_ =>
      {
        sts = DisableSourceReal();
      }, null);
      return sts;
    }
    STS DisableSourceReal()
    {
      _closeDsRequested = true;
      var rc = DGControl.UserInterface.DisableDS(ref _appIdentity, ref _currentDS, ref _userInterface);
      if (rc == TWRC.SUCCESS)
      {
        State = STATE.S4;
        SourceDisabled?.Invoke(this, _currentDS);
      }
      return WrapInSTS(rc);
    }

    /// <summary>
    /// Reads information relating to the last capture run.
    /// Only valid on state 4 after a capture.
    /// </summary>
    public STS GetMetrics(out TW_METRICS metrics)
    {
      return WrapInSTS(DGControl.Metrics.Get(ref _appIdentity, ref _currentDS, out metrics));
    }

    /// <summary>
    /// Sends a TWAIN Direct task from the application to the driver.
    /// </summary>
    /// <param name="taskJson">The TWAIN Direct task in JSON.</param>
    /// <param name="communicationManager">The current system being used to connect the application to the scanner.</param>
    /// <returns></returns>
    public TwainDirectTaskResult SetTwainDirectTask(string taskJson, ushort communicationManager = 0)
    {
      var result = new TwainDirectTaskResult { ReturnCode = TWRC.FAILURE };
      TW_TWAINDIRECT task = default;
      try
      {
        task.SizeOf = (uint)Marshal.SizeOf(typeof(TW_TWAINDIRECT));
        task.CommunicationManager = communicationManager;
        task.Send = taskJson.StringToPtrUTF8(this, out uint length);
        task.SendSize = length;

        result.ReturnCode = DGControl.TwainDirect.SetTask(ref _appIdentity, ref _currentDS, ref task);
        if (result.ReturnCode == TWRC.FAILURE)
        {
          result.Status = GetLastStatus();
        }
        else if (result.ReturnCode == TWRC.SUCCESS && task.ReceiveSize > 0 && task.Receive != IntPtr.Zero)
        {
          result.ResponseJson = task.Receive.PtrToStringUTF8(this, (int)task.ReceiveSize);
        }
      }
      finally
      {
        //if (task.Send != IntPtr.Zero) Free(task.Send); // does source free the Send?
        if (task.Receive != IntPtr.Zero) Free(task.Receive);
      }
      return result;
    }
  }
}
