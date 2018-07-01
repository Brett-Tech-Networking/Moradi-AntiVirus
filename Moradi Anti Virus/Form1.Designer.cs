namespace Moradi_Anti_Virus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ubuntuTheme1 = new Ubuntu_Theme.UbuntuTheme();
            this.faderTabControl1 = new Fader_Theme.FaderTabControl();
            this.Scanner = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ubuntuButtonGray1 = new Ubuntu_Theme.UbuntuButtonGray();
            this.faderAlertBox1 = new Fader_Theme.FaderAlertBox();
            this.ubuntuButtonGray4 = new Ubuntu_Theme.UbuntuButtonGray();
            this.ubuntuButtonGray3 = new Ubuntu_Theme.UbuntuButtonGray();
            this.ubuntuButtonGray2 = new Ubuntu_Theme.UbuntuButtonGray();
            this.faderProgressBar1 = new Fader_Theme.FaderProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuram = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.ubuntuButtonOrange1 = new Ubuntu_Theme.UbuntuButtonOrange();
            this.ubuntuTextBox1 = new Ubuntu_Theme.UbuntuTextBox();
            this.ubuntuButtonGray6 = new Ubuntu_Theme.UbuntuButtonGray();
            this.label3 = new System.Windows.Forms.Label();
            this.ubuntuButtonGray5 = new Ubuntu_Theme.UbuntuButtonGray();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.faderListBox1 = new Fader_Theme.FaderListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.AdvancedTools = new System.Windows.Forms.TabPage();
            this.About = new System.Windows.Forms.TabPage();
            this.faderPanel3 = new Fader_Theme.FaderPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.faderLabel7 = new Fader_Theme.FaderLabel();
            this.faderPanel2 = new Fader_Theme.FaderPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.faderLabel2 = new Fader_Theme.FaderLabel();
            this.faderPanel1 = new Fader_Theme.FaderPanel();
            this.faderLabel6 = new Fader_Theme.FaderLabel();
            this.faderLabel5 = new Fader_Theme.FaderLabel();
            this.faderLabel4 = new Fader_Theme.FaderLabel();
            this.faderLabel3 = new Fader_Theme.FaderLabel();
            this.faderLabel1 = new Fader_Theme.FaderLabel();
            this.ubuntuControlBox1 = new Ubuntu_Theme.UbuntuControlBox();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.SysInfo = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar = new System.Windows.Forms.Timer(this.components);
            this.TaskmgrTimer = new System.Windows.Forms.Timer(this.components);
            this.ubuntuTheme1.SuspendLayout();
            this.faderTabControl1.SuspendLayout();
            this.Scanner.SuspendLayout();
            this.cpuram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.About.SuspendLayout();
            this.faderPanel3.SuspendLayout();
            this.faderPanel2.SuspendLayout();
            this.faderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // ubuntuTheme1
            // 
            this.ubuntuTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ubuntuTheme1.Controls.Add(this.faderTabControl1);
            this.ubuntuTheme1.Controls.Add(this.ubuntuControlBox1);
            this.ubuntuTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubuntuTheme1.Location = new System.Drawing.Point(0, 0);
            this.ubuntuTheme1.Name = "ubuntuTheme1";
            this.ubuntuTheme1.Size = new System.Drawing.Size(736, 462);
            this.ubuntuTheme1.TabIndex = 0;
            this.ubuntuTheme1.Text = "Moradi Anti Virus | Brett Tech Networking";
            // 
            // faderTabControl1
            // 
            this.faderTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faderTabControl1.Controls.Add(this.Scanner);
            this.faderTabControl1.Controls.Add(this.cpuram);
            this.faderTabControl1.Controls.Add(this.AdvancedTools);
            this.faderTabControl1.Controls.Add(this.About);
            this.faderTabControl1.ItemSize = new System.Drawing.Size(100, 35);
            this.faderTabControl1.Location = new System.Drawing.Point(1, 26);
            this.faderTabControl1.Name = "faderTabControl1";
            this.faderTabControl1.SelectedIndex = 0;
            this.faderTabControl1.Size = new System.Drawing.Size(735, 436);
            this.faderTabControl1.TabIndex = 1;
            // 
            // Scanner
            // 
            this.Scanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Scanner.Controls.Add(this.listBox1);
            this.Scanner.Controls.Add(this.ubuntuButtonGray1);
            this.Scanner.Controls.Add(this.faderAlertBox1);
            this.Scanner.Controls.Add(this.ubuntuButtonGray4);
            this.Scanner.Controls.Add(this.ubuntuButtonGray3);
            this.Scanner.Controls.Add(this.ubuntuButtonGray2);
            this.Scanner.Controls.Add(this.faderProgressBar1);
            this.Scanner.Controls.Add(this.label2);
            this.Scanner.Location = new System.Drawing.Point(4, 39);
            this.Scanner.Name = "Scanner";
            this.Scanner.Padding = new System.Windows.Forms.Padding(3);
            this.Scanner.Size = new System.Drawing.Size(727, 393);
            this.Scanner.TabIndex = 0;
            this.Scanner.Text = "Scanner";
            this.Scanner.Click += new System.EventHandler(this.Scanner_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(171, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(529, 225);
            this.listBox1.TabIndex = 9;
            // 
            // ubuntuButtonGray1
            // 
            this.ubuntuButtonGray1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonGray1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.ubuntuButtonGray1.Location = new System.Drawing.Point(48, 244);
            this.ubuntuButtonGray1.Name = "ubuntuButtonGray1";
            this.ubuntuButtonGray1.Size = new System.Drawing.Size(117, 31);
            this.ubuntuButtonGray1.TabIndex = 8;
            this.ubuntuButtonGray1.Text = "Delete Cache";
            this.ubuntuButtonGray1.Click += new System.EventHandler(this.ubuntuButtonGray1_Click);
            // 
            // faderAlertBox1
            // 
            this.faderAlertBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faderAlertBox1.BackColor = System.Drawing.Color.Transparent;
            this.faderAlertBox1.Location = new System.Drawing.Point(35, 355);
            this.faderAlertBox1.Name = "faderAlertBox1";
            this.faderAlertBox1.Size = new System.Drawing.Size(643, 30);
            this.faderAlertBox1.Style = Fader_Theme.FaderAlertBox.AlertStyle.Info;
            this.faderAlertBox1.TabIndex = 6;
            this.faderAlertBox1.Text = "The Feature You Are Attempting To Use Is Not Yet Avalible Please Wait For An Upda" +
    "te";
            this.faderAlertBox1.Visible = false;
            // 
            // ubuntuButtonGray4
            // 
            this.ubuntuButtonGray4.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonGray4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.ubuntuButtonGray4.Location = new System.Drawing.Point(48, 126);
            this.ubuntuButtonGray4.Name = "ubuntuButtonGray4";
            this.ubuntuButtonGray4.Size = new System.Drawing.Size(117, 31);
            this.ubuntuButtonGray4.TabIndex = 5;
            this.ubuntuButtonGray4.Text = "Custom Scan";
            this.ubuntuButtonGray4.Click += new System.EventHandler(this.ubuntuButtonGray4_Click);
            // 
            // ubuntuButtonGray3
            // 
            this.ubuntuButtonGray3.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonGray3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.ubuntuButtonGray3.Location = new System.Drawing.Point(48, 89);
            this.ubuntuButtonGray3.Name = "ubuntuButtonGray3";
            this.ubuntuButtonGray3.Size = new System.Drawing.Size(117, 31);
            this.ubuntuButtonGray3.TabIndex = 4;
            this.ubuntuButtonGray3.Text = "Full Scan";
            this.ubuntuButtonGray3.Click += new System.EventHandler(this.ubuntuButtonGray3_Click);
            // 
            // ubuntuButtonGray2
            // 
            this.ubuntuButtonGray2.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonGray2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.ubuntuButtonGray2.Location = new System.Drawing.Point(48, 52);
            this.ubuntuButtonGray2.Name = "ubuntuButtonGray2";
            this.ubuntuButtonGray2.Size = new System.Drawing.Size(117, 31);
            this.ubuntuButtonGray2.TabIndex = 3;
            this.ubuntuButtonGray2.Text = "Quick Scan";
            this.ubuntuButtonGray2.Click += new System.EventHandler(this.ubuntuButtonGray2_Click);
            // 
            // faderProgressBar1
            // 
            this.faderProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faderProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.faderProgressBar1.ForeColor = System.Drawing.Color.Red;
            this.faderProgressBar1.Location = new System.Drawing.Point(16, 281);
            this.faderProgressBar1.Maximum = 100;
            this.faderProgressBar1.Name = "faderProgressBar1";
            this.faderProgressBar1.ShowPercentage = true;
            this.faderProgressBar1.Size = new System.Drawing.Size(703, 20);
            this.faderProgressBar1.TabIndex = 1;
            this.faderProgressBar1.Text = "faderProgressBar1";
            this.faderProgressBar1.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 20F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Moradi AntiVirus";
            // 
            // cpuram
            // 
            this.cpuram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cpuram.Controls.Add(this.label6);
            this.cpuram.Controls.Add(this.ubuntuButtonOrange1);
            this.cpuram.Controls.Add(this.ubuntuTextBox1);
            this.cpuram.Controls.Add(this.ubuntuButtonGray6);
            this.cpuram.Controls.Add(this.label3);
            this.cpuram.Controls.Add(this.ubuntuButtonGray5);
            this.cpuram.Controls.Add(this.pictureBox1);
            this.cpuram.Controls.Add(this.faderListBox1);
            this.cpuram.Controls.Add(this.label4);
            this.cpuram.Controls.Add(this.label5);
            this.cpuram.Controls.Add(this.circularProgressBar2);
            this.cpuram.Controls.Add(this.circularProgressBar1);
            this.cpuram.Location = new System.Drawing.Point(4, 39);
            this.cpuram.Name = "cpuram";
            this.cpuram.Size = new System.Drawing.Size(727, 393);
            this.cpuram.TabIndex = 2;
            this.cpuram.Text = "TaskMgr | CPU/RAM";
            this.cpuram.Click += new System.EventHandler(this.cpuram_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(560, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            // 
            // ubuntuButtonOrange1
            // 
            this.ubuntuButtonOrange1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonOrange1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ubuntuButtonOrange1.Location = new System.Drawing.Point(660, 361);
            this.ubuntuButtonOrange1.Name = "ubuntuButtonOrange1";
            this.ubuntuButtonOrange1.Size = new System.Drawing.Size(59, 29);
            this.ubuntuButtonOrange1.TabIndex = 13;
            this.ubuntuButtonOrange1.Text = "Search";
            this.ubuntuButtonOrange1.Click += new System.EventHandler(this.ubuntuButtonOrange1_Click);
            // 
            // ubuntuTextBox1
            // 
            this.ubuntuTextBox1.BackColor = System.Drawing.Color.White;
            this.ubuntuTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ubuntuTextBox1.Location = new System.Drawing.Point(537, 364);
            this.ubuntuTextBox1.MaxLength = 32767;
            this.ubuntuTextBox1.Name = "ubuntuTextBox1";
            this.ubuntuTextBox1.Size = new System.Drawing.Size(117, 26);
            this.ubuntuTextBox1.TabIndex = 12;
            this.ubuntuTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ubuntuTextBox1.UseSystemPasswordChar = false;
            // 
            // ubuntuButtonGray6
            // 
            this.ubuntuButtonGray6.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonGray6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.ubuntuButtonGray6.Location = new System.Drawing.Point(448, 364);
            this.ubuntuButtonGray6.Name = "ubuntuButtonGray6";
            this.ubuntuButtonGray6.Size = new System.Drawing.Size(72, 23);
            this.ubuntuButtonGray6.TabIndex = 11;
            this.ubuntuButtonGray6.Text = "New Task";
            this.ubuntuButtonGray6.Click += new System.EventHandler(this.ubuntuButtonGray6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(361, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Task Manager";
            // 
            // ubuntuButtonGray5
            // 
            this.ubuntuButtonGray5.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuButtonGray5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.ubuntuButtonGray5.Location = new System.Drawing.Point(364, 364);
            this.ubuntuButtonGray5.Name = "ubuntuButtonGray5";
            this.ubuntuButtonGray5.Size = new System.Drawing.Size(72, 23);
            this.ubuntuButtonGray5.TabIndex = 8;
            this.ubuntuButtonGray5.Text = "Kill Task";
            this.ubuntuButtonGray5.Click += new System.EventHandler(this.ubuntuButtonGray5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moradi_Anti_Virus.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(701, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // faderListBox1
            // 
            this.faderListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.faderListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.faderListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.faderListBox1.ForeColor = System.Drawing.Color.White;
            this.faderListBox1.FormattingEnabled = true;
            this.faderListBox1.ItemHeight = 20;
            this.faderListBox1.Location = new System.Drawing.Point(361, 16);
            this.faderListBox1.Name = "faderListBox1";
            this.faderListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.faderListBox1.Size = new System.Drawing.Size(335, 340);
            this.faderListBox1.Sorted = true;
            this.faderListBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(227, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "RAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(58, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "CPU";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.Lime;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(173, 5);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.Maroon;
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar2.Size = new System.Drawing.Size(161, 155);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 3;
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Lime;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(6, 5);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(161, 155);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // AdvancedTools
            // 
            this.AdvancedTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.AdvancedTools.Location = new System.Drawing.Point(4, 39);
            this.AdvancedTools.Name = "AdvancedTools";
            this.AdvancedTools.Size = new System.Drawing.Size(727, 393);
            this.AdvancedTools.TabIndex = 3;
            this.AdvancedTools.Text = "Advanced Tools";
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.About.Controls.Add(this.faderPanel3);
            this.About.Controls.Add(this.faderPanel2);
            this.About.Controls.Add(this.faderPanel1);
            this.About.Location = new System.Drawing.Point(4, 39);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(727, 393);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            // 
            // faderPanel3
            // 
            this.faderPanel3.BackColor = System.Drawing.Color.Transparent;
            this.faderPanel3.Controls.Add(this.button2);
            this.faderPanel3.Controls.Add(this.button1);
            this.faderPanel3.Controls.Add(this.label1);
            this.faderPanel3.Controls.Add(this.faderLabel7);
            this.faderPanel3.Location = new System.Drawing.Point(475, 6);
            this.faderPanel3.Name = "faderPanel3";
            this.faderPanel3.Size = new System.Drawing.Size(252, 379);
            this.faderPanel3.TabIndex = 2;
            this.faderPanel3.Text = "faderPanel3";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(-161, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Software Help";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(51, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Our Github";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 128);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // faderLabel7
            // 
            this.faderLabel7.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel7.Border = true;
            this.faderLabel7.Location = new System.Drawing.Point(45, 15);
            this.faderLabel7.Name = "faderLabel7";
            this.faderLabel7.Size = new System.Drawing.Size(150, 30);
            this.faderLabel7.TabIndex = 1;
            this.faderLabel7.Text = "Developer Info";
            // 
            // faderPanel2
            // 
            this.faderPanel2.BackColor = System.Drawing.Color.Transparent;
            this.faderPanel2.Controls.Add(this.button3);
            this.faderPanel2.Controls.Add(this.faderLabel2);
            this.faderPanel2.Location = new System.Drawing.Point(249, 6);
            this.faderPanel2.Name = "faderPanel2";
            this.faderPanel2.Size = new System.Drawing.Size(220, 379);
            this.faderPanel2.TabIndex = 1;
            this.faderPanel2.Text = "faderPanel2";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(42, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 63);
            this.button3.TabIndex = 1;
            this.button3.Text = "Software Help";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // faderLabel2
            // 
            this.faderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel2.Border = true;
            this.faderLabel2.Location = new System.Drawing.Point(36, 15);
            this.faderLabel2.Name = "faderLabel2";
            this.faderLabel2.Size = new System.Drawing.Size(150, 30);
            this.faderLabel2.TabIndex = 0;
            this.faderLabel2.Text = "Software Info";
            // 
            // faderPanel1
            // 
            this.faderPanel1.BackColor = System.Drawing.Color.Transparent;
            this.faderPanel1.Controls.Add(this.faderLabel6);
            this.faderPanel1.Controls.Add(this.faderLabel5);
            this.faderPanel1.Controls.Add(this.faderLabel4);
            this.faderPanel1.Controls.Add(this.faderLabel3);
            this.faderPanel1.Controls.Add(this.faderLabel1);
            this.faderPanel1.Location = new System.Drawing.Point(3, 6);
            this.faderPanel1.Name = "faderPanel1";
            this.faderPanel1.Size = new System.Drawing.Size(240, 379);
            this.faderPanel1.TabIndex = 0;
            this.faderPanel1.Text = "faderPanel1";
            // 
            // faderLabel6
            // 
            this.faderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel6.Border = false;
            this.faderLabel6.Location = new System.Drawing.Point(4, 174);
            this.faderLabel6.Name = "faderLabel6";
            this.faderLabel6.Size = new System.Drawing.Size(232, 30);
            this.faderLabel6.TabIndex = 7;
            this.faderLabel6.Text = "System Directory";
            this.faderLabel6.Visible = false;
            // 
            // faderLabel5
            // 
            this.faderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel5.Border = false;
            this.faderLabel5.Location = new System.Drawing.Point(3, 138);
            this.faderLabel5.Name = "faderLabel5";
            this.faderLabel5.Size = new System.Drawing.Size(233, 30);
            this.faderLabel5.TabIndex = 6;
            this.faderLabel5.Text = "Machine Name";
            this.faderLabel5.Visible = false;
            // 
            // faderLabel4
            // 
            this.faderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel4.Border = false;
            this.faderLabel4.Location = new System.Drawing.Point(3, 87);
            this.faderLabel4.Name = "faderLabel4";
            this.faderLabel4.Size = new System.Drawing.Size(233, 46);
            this.faderLabel4.TabIndex = 5;
            this.faderLabel4.Text = "OS";
            this.faderLabel4.Visible = false;
            // 
            // faderLabel3
            // 
            this.faderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel3.Border = false;
            this.faderLabel3.Location = new System.Drawing.Point(3, 51);
            this.faderLabel3.Name = "faderLabel3";
            this.faderLabel3.Size = new System.Drawing.Size(233, 30);
            this.faderLabel3.TabIndex = 3;
            this.faderLabel3.Text = "UserName";
            this.faderLabel3.Visible = false;
            // 
            // faderLabel1
            // 
            this.faderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.faderLabel1.Border = true;
            this.faderLabel1.ForeColor = System.Drawing.Color.Red;
            this.faderLabel1.Location = new System.Drawing.Point(45, 11);
            this.faderLabel1.Name = "faderLabel1";
            this.faderLabel1.Size = new System.Drawing.Size(150, 30);
            this.faderLabel1.TabIndex = 0;
            this.faderLabel1.Text = "System Info";
            // 
            // ubuntuControlBox1
            // 
            this.ubuntuControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuntuControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ubuntuControlBox1.Location = new System.Drawing.Point(671, 3);
            this.ubuntuControlBox1.Name = "ubuntuControlBox1";
            this.ubuntuControlBox1.Size = new System.Drawing.Size(75, 23);
            this.ubuntuControlBox1.TabIndex = 0;
            this.ubuntuControlBox1.Text = "ubuntuControlBox1";
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 462);
            this.Controls.Add(this.ubuntuTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moradi Anti Virus";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ubuntuTheme1.ResumeLayout(false);
            this.faderTabControl1.ResumeLayout(false);
            this.Scanner.ResumeLayout(false);
            this.Scanner.PerformLayout();
            this.cpuram.ResumeLayout(false);
            this.cpuram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.About.ResumeLayout(false);
            this.faderPanel3.ResumeLayout(false);
            this.faderPanel3.PerformLayout();
            this.faderPanel2.ResumeLayout(false);
            this.faderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ubuntu_Theme.UbuntuTheme ubuntuTheme1;
        private Ubuntu_Theme.UbuntuControlBox ubuntuControlBox1;
        private Fader_Theme.FaderTabControl faderTabControl1;
        private System.Windows.Forms.TabPage Scanner;
        private System.Windows.Forms.TabPage About;
        private Fader_Theme.FaderPanel faderPanel2;
        private Fader_Theme.FaderPanel faderPanel1;
        private Fader_Theme.FaderLabel faderLabel1;
        private Fader_Theme.FaderLabel faderLabel2;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.TabPage cpuram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private Fader_Theme.FaderLabel faderLabel3;
        private Fader_Theme.FaderLabel faderLabel4;
        private Fader_Theme.FaderLabel faderLabel5;
        private Fader_Theme.FaderLabel faderLabel6;
        private System.Windows.Forms.Timer SysInfo;
        private Fader_Theme.FaderPanel faderPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Fader_Theme.FaderLabel faderLabel7;
        private Ubuntu_Theme.UbuntuButtonGray ubuntuButtonGray4;
        private Ubuntu_Theme.UbuntuButtonGray ubuntuButtonGray3;
        private Ubuntu_Theme.UbuntuButtonGray ubuntuButtonGray2;
        private Fader_Theme.FaderProgressBar faderProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Fader_Theme.FaderAlertBox faderAlertBox1;
        private Ubuntu_Theme.UbuntuButtonGray ubuntuButtonGray1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer ProgressBar;
        private System.Windows.Forms.ListBox listBox1;
        private Fader_Theme.FaderListBox faderListBox1;
        private System.Windows.Forms.Timer TaskmgrTimer;
        private Ubuntu_Theme.UbuntuButtonGray ubuntuButtonGray5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Ubuntu_Theme.UbuntuButtonGray ubuntuButtonGray6;
        private Ubuntu_Theme.UbuntuButtonOrange ubuntuButtonOrange1;
        private Ubuntu_Theme.UbuntuTextBox ubuntuTextBox1;
        private System.Windows.Forms.TabPage AdvancedTools;
        private System.Windows.Forms.Label label6;
    }
}

