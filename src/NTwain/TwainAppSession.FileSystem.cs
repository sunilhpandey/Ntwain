using NTwain.Data;
using NTwain.Triplets;
using System.Collections.Generic;

namespace NTwain;

// this file contains FileSystem mgmt methods

partial class TwainAppSession
{
    /// <summary>
    /// Enumerate file system items at current level.
    /// </summary>
    /// <returns></returns>
    public IEnumerable<TW_FILESYSTEM> GetFileSystemItems()
    {
        TW_FILESYSTEM fs = default;
        for (var rc = DGControl.FileSystem.GetFirstFile(ref _appIdentity, ref _currentDS, ref fs);
            rc == TWRC.SUCCESS;
            rc = DGControl.FileSystem.GetNextFile(ref _appIdentity, ref _currentDS, ref fs))
        {
            yield return fs;
        }
    }

    /// <summary>
    /// Try to change to a different directory.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public STS ChangeFileSystemDirectory(TWFY type, string path)
    {
        TW_FILESYSTEM fs = new() { FileType = (int)type, InputName = path };
        return WrapInSTS(DGControl.FileSystem.ChangeDirectory(ref _appIdentity, ref _currentDS, ref fs));
    }
}
