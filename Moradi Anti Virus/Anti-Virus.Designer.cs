namespace Moradi_Anti_Virus
{
    partial class Anti_Virus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Virus));
            this.QuickScan = new MetroFramework.Controls.MetroButton();
            this.FullScan = new MetroFramework.Controls.MetroButton();
            this.CustomScan = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DelCache = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Scanner = new MetroFramework.Controls.MetroTabPage();
            this.time = new MetroFramework.Controls.MetroLabel();
            this.Opacity = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.faderAlertBox1 = new Fader_Theme.FaderAlertBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.TaskManager = new MetroFramework.Controls.MetroTabPage();
            this.Search = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.refresh = new MetroFramework.Controls.MetroButton();
            this.NewTask = new MetroFramework.Controls.MetroButton();
            this.KillTask = new MetroFramework.Controls.MetroButton();
            this.Status = new MetroFramework.Controls.MetroLabel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SystemInfo = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SSID = new MetroFramework.Controls.MetroLabel();
            this.mchName = new MetroFramework.Controls.MetroLabel();
            this.OS = new MetroFramework.Controls.MetroLabel();
            this.usrname = new MetroFramework.Controls.MetroLabel();
            this.SysInfoLabel = new MetroFramework.Controls.MetroLabel();
            this.AppSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.TopMostOnOff = new MetroFramework.Controls.MetroLabel();
            this.CPURAM = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.SysInfo = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar = new System.Windows.Forms.Timer(this.components);
            this.TaskmgrTimer = new System.Windows.Forms.Timer(this.components);
            this.OpacityControl = new System.Windows.Forms.Timer(this.components);
            this.CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.monitor = new MetroFramework.Controls.MetroTabPage();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar3 = new MetroFramework.Controls.MetroProgressBar();
            this.CPUMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.RAMMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.CPUPercent = new MetroFramework.Controls.MetroLabel();
            this.RAMPercent = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.Scanner.SuspendLayout();
            this.TaskManager.SuspendLayout();
            this.SystemInfo.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.AppSettings.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            this.monitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuickScan
            // 
            this.QuickScan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.QuickScan.Location = new System.Drawing.Point(34, 27);
            this.QuickScan.Name = "QuickScan";
            this.QuickScan.Size = new System.Drawing.Size(120, 30);
            this.QuickScan.Style = MetroFramework.MetroColorStyle.Red;
            this.QuickScan.TabIndex = 0;
            this.QuickScan.Text = "Quick Scan";
            this.QuickScan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.QuickScan.UseSelectable = true;
            this.QuickScan.UseStyleColors = true;
            this.QuickScan.Click += new System.EventHandler(this.QuickScan_Click);
            // 
            // FullScan
            // 
            this.FullScan.DisplayFocus = true;
            this.FullScan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.FullScan.Location = new System.Drawing.Point(34, 63);
            this.FullScan.Name = "FullScan";
            this.FullScan.Size = new System.Drawing.Size(120, 30);
            this.FullScan.Style = MetroFramework.MetroColorStyle.Red;
            this.FullScan.TabIndex = 1;
            this.FullScan.Text = "Full Scan";
            this.FullScan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FullScan.UseSelectable = true;
            this.FullScan.UseStyleColors = true;
            this.FullScan.Click += new System.EventHandler(this.FullScan_Click);
            // 
            // CustomScan
            // 
            this.CustomScan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CustomScan.Location = new System.Drawing.Point(34, 99);
            this.CustomScan.Name = "CustomScan";
            this.CustomScan.Size = new System.Drawing.Size(120, 30);
            this.CustomScan.Style = MetroFramework.MetroColorStyle.Red;
            this.CustomScan.TabIndex = 2;
            this.CustomScan.Text = "Custom Scan";
            this.CustomScan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CustomScan.UseSelectable = true;
            this.CustomScan.UseStyleColors = true;
            this.CustomScan.Click += new System.EventHandler(this.CustomScan_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(160, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(923, 394);
            this.listBox1.TabIndex = 3;
            // 
            // DelCache
            // 
            this.DelCache.AutoSize = true;
            this.DelCache.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DelCache.Location = new System.Drawing.Point(34, 370);
            this.DelCache.Name = "DelCache";
            this.DelCache.Size = new System.Drawing.Size(120, 37);
            this.DelCache.Style = MetroFramework.MetroColorStyle.Red;
            this.DelCache.TabIndex = 4;
            this.DelCache.Text = "Delete Cache";
            this.DelCache.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DelCache.UseSelectable = true;
            this.DelCache.UseStyleColors = true;
            this.DelCache.Click += new System.EventHandler(this.DelCache_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Scanner);
            this.metroTabControl1.Controls.Add(this.TaskManager);
            this.metroTabControl1.Controls.Add(this.monitor);
            this.metroTabControl1.Controls.Add(this.SystemInfo);
            this.metroTabControl1.Controls.Add(this.AppSettings);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 4;
            this.metroTabControl1.Size = new System.Drawing.Size(1102, 565);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Scanner
            // 
            this.Scanner.BackColor = System.Drawing.Color.Crimson;
            this.Scanner.Controls.Add(this.time);
            this.Scanner.Controls.Add(this.Opacity);
            this.Scanner.Controls.Add(this.metroTrackBar1);
            this.Scanner.Controls.Add(this.faderAlertBox1);
            this.Scanner.Controls.Add(this.metroProgressBar1);
            this.Scanner.Controls.Add(this.DelCache);
            this.Scanner.Controls.Add(this.listBox1);
            this.Scanner.Controls.Add(this.CustomScan);
            this.Scanner.Controls.Add(this.QuickScan);
            this.Scanner.Controls.Add(this.FullScan);
            this.Scanner.HorizontalScrollbarBarColor = true;
            this.Scanner.HorizontalScrollbarHighlightOnWheel = false;
            this.Scanner.HorizontalScrollbarSize = 10;
            this.Scanner.Location = new System.Drawing.Point(4, 38);
            this.Scanner.Name = "Scanner";
            this.Scanner.Size = new System.Drawing.Size(1094, 523);
            this.Scanner.Style = MetroFramework.MetroColorStyle.Blue;
            this.Scanner.TabIndex = 0;
            this.Scanner.Text = "Scanner";
            this.Scanner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Scanner.VerticalScrollbarBarColor = true;
            this.Scanner.VerticalScrollbarHighlightOnWheel = false;
            this.Scanner.VerticalScrollbarSize = 10;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.time.Location = new System.Drawing.Point(993, 4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(85, 19);
            this.time.Style = MetroFramework.MetroColorStyle.Yellow;
            this.time.TabIndex = 9;
            this.time.Text = "00:00:00:00";
            this.time.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.time.UseStyleColors = true;
            // 
            // Opacity
            // 
            this.Opacity.AutoSize = true;
            this.Opacity.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Opacity.Location = new System.Drawing.Point(25, 470);
            this.Opacity.Name = "Opacity";
            this.Opacity.Size = new System.Drawing.Size(115, 19);
            this.Opacity.Style = MetroFramework.MetroColorStyle.Red;
            this.Opacity.TabIndex = 8;
            this.Opacity.Text = "Opacity Control";
            this.Opacity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Opacity.UseStyleColors = true;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(6, 492);
            this.metroTrackBar1.Minimum = 75;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(148, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTrackBar1.TabIndex = 7;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBar1.Value = 100;
            // 
            // faderAlertBox1
            // 
            this.faderAlertBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.faderAlertBox1.BackColor = System.Drawing.Color.Transparent;
            this.faderAlertBox1.Location = new System.Drawing.Point(199, 470);
            this.faderAlertBox1.Name = "faderAlertBox1";
            this.faderAlertBox1.Size = new System.Drawing.Size(862, 30);
            this.faderAlertBox1.Style = Fader_Theme.FaderAlertBox.AlertStyle.Info;
            this.faderAlertBox1.TabIndex = 6;
            this.faderAlertBox1.Text = "faderAlertBox1";
            this.faderAlertBox1.Visible = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressBar1.Location = new System.Drawing.Point(160, 427);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(923, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBar1.TabIndex = 5;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TaskManager
            // 
            this.TaskManager.BackColor = System.Drawing.Color.Black;
            this.TaskManager.Controls.Add(this.Search);
            this.TaskManager.Controls.Add(this.metroTextBox1);
            this.TaskManager.Controls.Add(this.refresh);
            this.TaskManager.Controls.Add(this.NewTask);
            this.TaskManager.Controls.Add(this.KillTask);
            this.TaskManager.Controls.Add(this.Status);
            this.TaskManager.Controls.Add(this.listBox2);
            this.TaskManager.HorizontalScrollbarBarColor = true;
            this.TaskManager.HorizontalScrollbarHighlightOnWheel = false;
            this.TaskManager.HorizontalScrollbarSize = 10;
            this.TaskManager.Location = new System.Drawing.Point(4, 38);
            this.TaskManager.Name = "TaskManager";
            this.TaskManager.Size = new System.Drawing.Size(1094, 523);
            this.TaskManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.TaskManager.TabIndex = 1;
            this.TaskManager.Text = "Task Manager";
            this.TaskManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TaskManager.VerticalScrollbarBarColor = true;
            this.TaskManager.VerticalScrollbarHighlightOnWheel = false;
            this.TaskManager.VerticalScrollbarSize = 10;
            // 
            // Search
            // 
            this.Search.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Search.Location = new System.Drawing.Point(942, 479);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.Style = MetroFramework.MetroColorStyle.Lime;
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Search.UseSelectable = true;
            this.Search.UseStyleColors = true;
            this.Search.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(871, 450);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(212, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox1.TabIndex = 7;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // refresh
            // 
            this.refresh.Highlight = true;
            this.refresh.Location = new System.Drawing.Point(746, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.Style = MetroFramework.MetroColorStyle.Blue;
            this.refresh.TabIndex = 6;
            this.refresh.Text = "Refresh";
            this.refresh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.refresh.UseSelectable = true;
            this.refresh.UseStyleColors = true;
            // 
            // NewTask
            // 
            this.NewTask.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.NewTask.Location = new System.Drawing.Point(746, 445);
            this.NewTask.Name = "NewTask";
            this.NewTask.Size = new System.Drawing.Size(107, 28);
            this.NewTask.Style = MetroFramework.MetroColorStyle.Yellow;
            this.NewTask.TabIndex = 5;
            this.NewTask.Text = "New Task";
            this.NewTask.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NewTask.UseSelectable = true;
            this.NewTask.UseStyleColors = true;
            this.NewTask.Click += new System.EventHandler(this.NewTask_Click);
            // 
            // KillTask
            // 
            this.KillTask.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.KillTask.Location = new System.Drawing.Point(746, 479);
            this.KillTask.Name = "KillTask";
            this.KillTask.Size = new System.Drawing.Size(107, 28);
            this.KillTask.Style = MetroFramework.MetroColorStyle.Red;
            this.KillTask.TabIndex = 4;
            this.KillTask.Text = "Kill Task";
            this.KillTask.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KillTask.UseSelectable = true;
            this.KillTask.UseStyleColors = true;
            this.KillTask.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Status.Location = new System.Drawing.Point(950, 3);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(59, 19);
            this.Status.Style = MetroFramework.MetroColorStyle.Red;
            this.Status.TabIndex = 3;
            this.Status.Text = "STATUS";
            this.Status.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Status.UseStyleColors = true;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Black;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.Lime;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(737, 504);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 2;
            // 
            // SystemInfo
            // 
            this.SystemInfo.Controls.Add(this.metroPanel1);
            this.SystemInfo.HorizontalScrollbarBarColor = true;
            this.SystemInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.SystemInfo.HorizontalScrollbarSize = 10;
            this.SystemInfo.Location = new System.Drawing.Point(4, 38);
            this.SystemInfo.Name = "SystemInfo";
            this.SystemInfo.Size = new System.Drawing.Size(1094, 523);
            this.SystemInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.SystemInfo.TabIndex = 3;
            this.SystemInfo.Text = "System Info";
            this.SystemInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SystemInfo.VerticalScrollbarBarColor = true;
            this.SystemInfo.VerticalScrollbarHighlightOnWheel = false;
            this.SystemInfo.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.SSID);
            this.metroPanel1.Controls.Add(this.mchName);
            this.metroPanel1.Controls.Add(this.OS);
            this.metroPanel1.Controls.Add(this.usrname);
            this.metroPanel1.Controls.Add(this.SysInfoLabel);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 16);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(524, 499);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SSID
            // 
            this.SSID.AutoSize = true;
            this.SSID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SSID.Location = new System.Drawing.Point(23, 145);
            this.SSID.Name = "SSID";
            this.SSID.Size = new System.Drawing.Size(43, 19);
            this.SSID.Style = MetroFramework.MetroColorStyle.Red;
            this.SSID.TabIndex = 6;
            this.SSID.Text = "SSID:";
            this.SSID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SSID.UseStyleColors = true;
            // 
            // mchName
            // 
            this.mchName.AutoSize = true;
            this.mchName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mchName.Location = new System.Drawing.Point(23, 112);
            this.mchName.Name = "mchName";
            this.mchName.Size = new System.Drawing.Size(113, 19);
            this.mchName.Style = MetroFramework.MetroColorStyle.Red;
            this.mchName.TabIndex = 5;
            this.mchName.Text = "Machine Name:";
            this.mchName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mchName.UseStyleColors = true;
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.OS.Location = new System.Drawing.Point(23, 82);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(137, 19);
            this.OS.Style = MetroFramework.MetroColorStyle.Red;
            this.OS.TabIndex = 4;
            this.OS.Text = "Operating System: ";
            this.OS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OS.UseStyleColors = true;
            // 
            // usrname
            // 
            this.usrname.AutoSize = true;
            this.usrname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.usrname.Location = new System.Drawing.Point(23, 53);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(84, 19);
            this.usrname.Style = MetroFramework.MetroColorStyle.Red;
            this.usrname.TabIndex = 3;
            this.usrname.Text = "Username: ";
            this.usrname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.usrname.UseStyleColors = true;
            // 
            // SysInfoLabel
            // 
            this.SysInfoLabel.AutoSize = true;
            this.SysInfoLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SysInfoLabel.Location = new System.Drawing.Point(3, 9);
            this.SysInfoLabel.Name = "SysInfoLabel";
            this.SysInfoLabel.Size = new System.Drawing.Size(140, 19);
            this.SysInfoLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.SysInfoLabel.TabIndex = 2;
            this.SysInfoLabel.Text = "System Information";
            this.SysInfoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SysInfoLabel.UseStyleColors = true;
            // 
            // AppSettings
            // 
            this.AppSettings.Controls.Add(this.button1);
            this.AppSettings.Controls.Add(this.metroPanel2);
            this.AppSettings.HorizontalScrollbarBarColor = true;
            this.AppSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.AppSettings.HorizontalScrollbarSize = 10;
            this.AppSettings.Location = new System.Drawing.Point(4, 38);
            this.AppSettings.Name = "AppSettings";
            this.AppSettings.Size = new System.Drawing.Size(1094, 523);
            this.AppSettings.Style = MetroFramework.MetroColorStyle.Blue;
            this.AppSettings.TabIndex = 4;
            this.AppSettings.Text = "Settings";
            this.AppSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AppSettings.UseStyleColors = true;
            this.AppSettings.VerticalScrollbarBarColor = true;
            this.AppSettings.VerticalScrollbarHighlightOnWheel = false;
            this.AppSettings.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroToggle1);
            this.metroPanel2.Controls.Add(this.TopMostOnOff);
            this.metroPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(5, 13);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(166, 87);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(21, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Top Most Disabled";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.DisplayFocus = true;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroToggle1.Location = new System.Drawing.Point(30, 53);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroToggle1.TabIndex = 3;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.UseStyleColors = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // TopMostOnOff
            // 
            this.TopMostOnOff.AutoSize = true;
            this.TopMostOnOff.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TopMostOnOff.Location = new System.Drawing.Point(3, 0);
            this.TopMostOnOff.Name = "TopMostOnOff";
            this.TopMostOnOff.Size = new System.Drawing.Size(71, 19);
            this.TopMostOnOff.Style = MetroFramework.MetroColorStyle.Red;
            this.TopMostOnOff.TabIndex = 2;
            this.TopMostOnOff.Text = "Top Most";
            this.TopMostOnOff.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMostOnOff.UseStyleColors = true;
            // 
            // CPURAM
            // 
            this.CPURAM.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // SysInfo
            // 
            this.SysInfo.Enabled = true;
            this.SysInfo.Tick += new System.EventHandler(this.SysInfo_Tick);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Tick += new System.EventHandler(this.ProgressBar_Tick);
            // 
            // TaskmgrTimer
            // 
            this.TaskmgrTimer.Enabled = true;
            this.TaskmgrTimer.Tick += new System.EventHandler(this.TaskmgrTimer_Tick);
            // 
            // OpacityControl
            // 
            this.OpacityControl.Enabled = true;
            this.OpacityControl.Interval = 500;
            this.OpacityControl.Tick += new System.EventHandler(this.OpacityControl_Tick);
            // 
            // CurrentTime
            // 
            this.CurrentTime.Enabled = true;
            this.CurrentTime.Tick += new System.EventHandler(this.CurrentTime_Tick);
            // 
            // monitor
            // 
            this.monitor.Controls.Add(this.chart1);
            this.monitor.Controls.Add(this.metroProgressBar3);
            this.monitor.Controls.Add(this.RAMPercent);
            this.monitor.Controls.Add(this.CPUPercent);
            this.monitor.Controls.Add(this.RAMMetroLabel);
            this.monitor.Controls.Add(this.CPUMetroLabel);
            this.monitor.Controls.Add(this.metroProgressBar2);
            this.monitor.HorizontalScrollbarBarColor = true;
            this.monitor.HorizontalScrollbarHighlightOnWheel = false;
            this.monitor.HorizontalScrollbarSize = 10;
            this.monitor.Location = new System.Drawing.Point(4, 38);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(1094, 523);
            this.monitor.Style = MetroFramework.MetroColorStyle.Blue;
            this.monitor.TabIndex = 5;
            this.monitor.Text = "CPU/RAM Monitor";
            this.monitor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.monitor.UseStyleColors = true;
            this.monitor.VerticalScrollbarBarColor = true;
            this.monitor.VerticalScrollbarHighlightOnWheel = false;
            this.monitor.VerticalScrollbarSize = 10;
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(148, 3);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(784, 43);
            this.metroProgressBar2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBar2.TabIndex = 2;
            this.metroProgressBar2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroProgressBar3
            // 
            this.metroProgressBar3.Location = new System.Drawing.Point(148, 52);
            this.metroProgressBar3.Name = "metroProgressBar3";
            this.metroProgressBar3.Size = new System.Drawing.Size(784, 45);
            this.metroProgressBar3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBar3.TabIndex = 3;
            this.metroProgressBar3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CPUMetroLabel
            // 
            this.CPUMetroLabel.AutoSize = true;
            this.CPUMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CPUMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CPUMetroLabel.Location = new System.Drawing.Point(88, 12);
            this.CPUMetroLabel.Name = "CPUMetroLabel";
            this.CPUMetroLabel.Size = new System.Drawing.Size(47, 25);
            this.CPUMetroLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.CPUMetroLabel.TabIndex = 4;
            this.CPUMetroLabel.Text = "CPU";
            this.CPUMetroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CPUMetroLabel.UseStyleColors = true;
            // 
            // RAMMetroLabel
            // 
            this.RAMMetroLabel.AutoSize = true;
            this.RAMMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RAMMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.RAMMetroLabel.Location = new System.Drawing.Point(88, 63);
            this.RAMMetroLabel.Name = "RAMMetroLabel";
            this.RAMMetroLabel.Size = new System.Drawing.Size(54, 25);
            this.RAMMetroLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.RAMMetroLabel.TabIndex = 5;
            this.RAMMetroLabel.Text = "RAM";
            this.RAMMetroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RAMMetroLabel.UseStyleColors = true;
            // 
            // CPUPercent
            // 
            this.CPUPercent.AutoSize = true;
            this.CPUPercent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CPUPercent.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CPUPercent.Location = new System.Drawing.Point(938, 12);
            this.CPUPercent.Name = "CPUPercent";
            this.CPUPercent.Size = new System.Drawing.Size(38, 25);
            this.CPUPercent.Style = MetroFramework.MetroColorStyle.Yellow;
            this.CPUPercent.TabIndex = 6;
            this.CPUPercent.Text = "0%";
            this.CPUPercent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CPUPercent.UseStyleColors = true;
            // 
            // RAMPercent
            // 
            this.RAMPercent.AutoSize = true;
            this.RAMPercent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RAMPercent.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.RAMPercent.Location = new System.Drawing.Point(938, 63);
            this.RAMPercent.Name = "RAMPercent";
            this.RAMPercent.Size = new System.Drawing.Size(38, 25);
            this.RAMPercent.Style = MetroFramework.MetroColorStyle.Yellow;
            this.RAMPercent.TabIndex = 7;
            this.RAMPercent.Text = "0%";
            this.RAMPercent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RAMPercent.UseStyleColors = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 121);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1098, 395);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Anti_Virus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 639);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Anti_Virus";
            this.Resizable = false;
            this.Text = "Moradi Anti Virus Protection";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Anti_Virus_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.Scanner.ResumeLayout(false);
            this.Scanner.PerformLayout();
            this.TaskManager.ResumeLayout(false);
            this.TaskManager.PerformLayout();
            this.SystemInfo.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.AppSettings.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            this.monitor.ResumeLayout(false);
            this.monitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton QuickScan;
        private MetroFramework.Controls.MetroButton FullScan;
        private MetroFramework.Controls.MetroButton CustomScan;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton DelCache;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Scanner;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private Fader_Theme.FaderAlertBox faderAlertBox1;
        private System.Windows.Forms.Timer CPURAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Timer SysInfo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer ProgressBar;
        private System.Windows.Forms.Timer TaskmgrTimer;
        private MetroFramework.Controls.MetroTabPage TaskManager;
        private System.Windows.Forms.ListBox listBox2;
        private MetroFramework.Controls.MetroLabel Status;
        private MetroFramework.Controls.MetroButton KillTask;
        private MetroFramework.Controls.MetroButton NewTask;
        private MetroFramework.Controls.MetroButton refresh;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton Search;
        private MetroFramework.Controls.MetroTabPage SystemInfo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel SSID;
        private MetroFramework.Controls.MetroLabel mchName;
        private MetroFramework.Controls.MetroLabel OS;
        private MetroFramework.Controls.MetroLabel usrname;
        private MetroFramework.Controls.MetroLabel SysInfoLabel;
        private new MetroFramework.Controls.MetroLabel Opacity;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTabPage AppSettings;
        private System.Windows.Forms.Timer OpacityControl;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel TopMostOnOff;
        private MetroFramework.Controls.MetroLabel time;
        private System.Windows.Forms.Timer CurrentTime;
        private MetroFramework.Controls.MetroTabPage monitor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel RAMPercent;
        private MetroFramework.Controls.MetroLabel CPUPercent;
        private MetroFramework.Controls.MetroLabel RAMMetroLabel;
        private MetroFramework.Controls.MetroLabel CPUMetroLabel;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar3;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private System.Windows.Forms.Button button1;
    }
}