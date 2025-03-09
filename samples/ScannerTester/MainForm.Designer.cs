namespace ScannerTester
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSelectScanner = new Button();
            groupSettings = new GroupBox();
            listFormat = new ComboBox();
            label7 = new Label();
            boxNamePrefix = new TextBox();
            label6 = new Label();
            btnOpenFolder = new Button();
            btnBrowseFolder = new Button();
            boxFolder = new TextBox();
            label5 = new Label();
            boxLimit = new NumericUpDown();
            label4 = new Label();
            listDpi = new ComboBox();
            label3 = new Label();
            lblCurScanner = new Label();
            groupTest = new GroupBox();
            boxLog = new RichTextBox();
            label2 = new Label();
            ckShowUI = new CheckBox();
            btnStop = new Button();
            btnTransfer = new Button();
            btnDriverOnly = new Button();
            groupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxLimit).BeginInit();
            groupTest.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(612, 25);
            label1.TabIndex = 0;
            label1.Text = "Use this tool to see if the scanner can be used with the ScanCloud Scan App";
            // 
            // btnSelectScanner
            // 
            btnSelectScanner.Location = new Point(12, 46);
            btnSelectScanner.Name = "btnSelectScanner";
            btnSelectScanner.Size = new Size(238, 34);
            btnSelectScanner.TabIndex = 1;
            btnSelectScanner.Text = "Choose Scanner...";
            btnSelectScanner.UseVisualStyleBackColor = true;
            btnSelectScanner.Click += btnSelectScanner_Click;
            // 
            // groupSettings
            // 
            groupSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupSettings.Controls.Add(listFormat);
            groupSettings.Controls.Add(label7);
            groupSettings.Controls.Add(boxNamePrefix);
            groupSettings.Controls.Add(label6);
            groupSettings.Controls.Add(btnOpenFolder);
            groupSettings.Controls.Add(btnBrowseFolder);
            groupSettings.Controls.Add(boxFolder);
            groupSettings.Controls.Add(label5);
            groupSettings.Controls.Add(boxLimit);
            groupSettings.Controls.Add(label4);
            groupSettings.Controls.Add(listDpi);
            groupSettings.Controls.Add(label3);
            groupSettings.Location = new Point(12, 99);
            groupSettings.Name = "groupSettings";
            groupSettings.Size = new Size(742, 932);
            groupSettings.TabIndex = 2;
            groupSettings.TabStop = false;
            groupSettings.Text = "Settings";
            // 
            // listFormat
            // 
            listFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            listFormat.FormattingEnabled = true;
            listFormat.Location = new Point(157, 243);
            listFormat.Name = "listFormat";
            listFormat.Size = new Size(182, 33);
            listFormat.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 246);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 9;
            label7.Text = "File Format";
            // 
            // boxNamePrefix
            // 
            boxNamePrefix.Location = new Point(157, 207);
            boxNamePrefix.Name = "boxNamePrefix";
            boxNamePrefix.Size = new Size(182, 31);
            boxNamePrefix.TabIndex = 8;
            boxNamePrefix.Text = "Capture_";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 210);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 7;
            label6.Text = "File Name Prefix";
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Location = new Point(275, 167);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new Size(112, 34);
            btnOpenFolder.TabIndex = 6;
            btnOpenFolder.Text = "Open";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Location = new Point(157, 167);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new Size(112, 34);
            btnBrowseFolder.TabIndex = 6;
            btnBrowseFolder.Text = "Browse...";
            btnBrowseFolder.UseVisualStyleBackColor = true;
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // boxFolder
            // 
            boxFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxFolder.Location = new Point(157, 130);
            boxFolder.Name = "boxFolder";
            boxFolder.Size = new Size(556, 31);
            boxFolder.TabIndex = 5;
            boxFolder.Text = "Images";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 133);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 4;
            label5.Text = "Save Folder";
            // 
            // boxLimit
            // 
            boxLimit.Location = new Point(157, 93);
            boxLimit.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            boxLimit.Name = "boxLimit";
            boxLimit.Size = new Size(182, 31);
            boxLimit.TabIndex = 3;
            boxLimit.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 95);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 2;
            label4.Text = "Transfer Limit";
            // 
            // listDpi
            // 
            listDpi.DropDownStyle = ComboBoxStyle.DropDownList;
            listDpi.FormattingEnabled = true;
            listDpi.Location = new Point(157, 54);
            listDpi.Name = "listDpi";
            listDpi.Size = new Size(182, 33);
            listDpi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 57);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 0;
            label3.Text = "DPI";
            // 
            // lblCurScanner
            // 
            lblCurScanner.AutoSize = true;
            lblCurScanner.Location = new Point(256, 51);
            lblCurScanner.Name = "lblCurScanner";
            lblCurScanner.Size = new Size(124, 25);
            lblCurScanner.TabIndex = 3;
            lblCurScanner.Text = "None selected";
            // 
            // groupTest
            // 
            groupTest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupTest.Controls.Add(boxLog);
            groupTest.Controls.Add(label2);
            groupTest.Controls.Add(ckShowUI);
            groupTest.Controls.Add(btnStop);
            groupTest.Controls.Add(btnTransfer);
            groupTest.Controls.Add(btnDriverOnly);
            groupTest.Location = new Point(760, 99);
            groupTest.Name = "groupTest";
            groupTest.Size = new Size(1038, 932);
            groupTest.TabIndex = 4;
            groupTest.TabStop = false;
            groupTest.Text = "Test";
            // 
            // boxLog
            // 
            boxLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxLog.Location = new Point(22, 118);
            boxLog.Name = "boxLog";
            boxLog.Size = new Size(999, 796);
            boxLog.TabIndex = 4;
            boxLog.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 90);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 3;
            label2.Text = "Logs";
            // 
            // ckShowUI
            // 
            ckShowUI.AutoSize = true;
            ckShowUI.Location = new Point(451, 43);
            ckShowUI.Name = "ckShowUI";
            ckShowUI.Size = new Size(253, 29);
            ckShowUI.TabIndex = 2;
            ckShowUI.Text = "Show driver during capture";
            ckShowUI.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStop.Location = new Point(897, 39);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(124, 34);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(239, 39);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(206, 34);
            btnTransfer.TabIndex = 1;
            btnTransfer.Text = "Start Capture";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnDriverOnly
            // 
            btnDriverOnly.Location = new Point(22, 39);
            btnDriverOnly.Name = "btnDriverOnly";
            btnDriverOnly.Size = new Size(206, 34);
            btnDriverOnly.TabIndex = 0;
            btnDriverOnly.Text = "Open Driver UI";
            btnDriverOnly.UseVisualStyleBackColor = true;
            btnDriverOnly.Click += btnDriverOnly_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1810, 1043);
            Controls.Add(groupTest);
            Controls.Add(lblCurScanner);
            Controls.Add(groupSettings);
            Controls.Add(btnSelectScanner);
            Controls.Add(label1);
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Scanner Tester Utility";
            groupSettings.ResumeLayout(false);
            groupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boxLimit).EndInit();
            groupTest.ResumeLayout(false);
            groupTest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSelectScanner;
        private GroupBox groupSettings;
        private Label lblCurScanner;
        private GroupBox groupTest;
        private CheckBox ckShowUI;
        private Button btnTransfer;
        private Button btnDriverOnly;
        private RichTextBox boxLog;
        private Label label2;
        private Button btnStop;
        private ComboBox listDpi;
        private Label label3;
        private Label label4;
        private NumericUpDown boxLimit;
        private Label label5;
        private Button btnOpenFolder;
        private Button btnBrowseFolder;
        private TextBox boxFolder;
        private TextBox boxNamePrefix;
        private Label label6;
        private ComboBox listFormat;
        private Label label7;
    }
}
