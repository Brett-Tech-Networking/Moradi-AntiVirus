namespace Moradi_Anti_Virus
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            this.ubuntuTheme1 = new Ubuntu_Theme.UbuntuTheme();
            this.faderPanel1 = new Fader_Theme.FaderPanel();
            this.ubuntuControlBox1 = new Ubuntu_Theme.UbuntuControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ubuntuTheme1.SuspendLayout();
            this.faderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ubuntuTheme1
            // 
            this.ubuntuTheme1.BackColor = System.Drawing.Color.Black;
            this.ubuntuTheme1.Controls.Add(this.ubuntuControlBox1);
            this.ubuntuTheme1.Controls.Add(this.faderPanel1);
            this.ubuntuTheme1.Location = new System.Drawing.Point(0, 0);
            this.ubuntuTheme1.Name = "ubuntuTheme1";
            this.ubuntuTheme1.Size = new System.Drawing.Size(537, 378);
            this.ubuntuTheme1.TabIndex = 0;
            this.ubuntuTheme1.Text = "Moradi AntiVirus Help";
            // 
            // faderPanel1
            // 
            this.faderPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faderPanel1.BackColor = System.Drawing.Color.Transparent;
            this.faderPanel1.Controls.Add(this.label1);
            this.faderPanel1.Location = new System.Drawing.Point(0, 26);
            this.faderPanel1.Name = "faderPanel1";
            this.faderPanel1.Size = new System.Drawing.Size(537, 352);
            this.faderPanel1.TabIndex = 0;
            this.faderPanel1.Text = "faderPanel1";
            // 
            // ubuntuControlBox1
            // 
            this.ubuntuControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuntuControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ubuntuControlBox1.Location = new System.Drawing.Point(470, 2);
            this.ubuntuControlBox1.Name = "ubuntuControlBox1";
            this.ubuntuControlBox1.Size = new System.Drawing.Size(75, 23);
            this.ubuntuControlBox1.TabIndex = 0;
            this.ubuntuControlBox1.Text = "ubuntuControlBox1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 378);
            this.Controls.Add(this.ubuntuTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "help";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ubuntuTheme1.ResumeLayout(false);
            this.faderPanel1.ResumeLayout(false);
            this.faderPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Ubuntu_Theme.UbuntuTheme ubuntuTheme1;
        private Ubuntu_Theme.UbuntuControlBox ubuntuControlBox1;
        private Fader_Theme.FaderPanel faderPanel1;
        private System.Windows.Forms.Label label1;
    }
}