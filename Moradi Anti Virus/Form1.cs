using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Moradi_Anti_Virus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process[] proc;

        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            faderListBox1.Items.Clear();
            foreach (Process p in proc)
                faderListBox1.Items.Add(p.ProcessName);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            float dram = RAM.NextValue();

            // cpu
            circularProgressBar1.Value = (int)fcpu;
            circularProgressBar1.Text = string.Format("{0:0.00}%", fcpu);

            // ram
            circularProgressBar2.Value = (int)dram;
            circularProgressBar2.Text = string.Format("{0:0.00}%", dram);
        }

        private void faderButton1_Click(object sender, EventArgs e)
        {

        }

        private void SysInfo_Tick(object sender, EventArgs e)
        {
            try
            {

                // username
                faderLabel3.Visible = true;
                faderLabel3.Text = "Username: " + Environment.UserName;

                // Operating System
                faderLabel4.Visible = true;
                faderLabel4.Text = "OS: " + Environment.OSVersion;

                // Machine Name
                faderLabel5.Visible = true;
                faderLabel5.Text = "PC Name: " + Environment.MachineName;

                //
                faderLabel6.Visible = true;
                faderLabel6.Text = "Sys Dir: " + Environment.SystemDirectory;
            }
            catch
            {
                MessageBox.Show("We Encounterd An Issue While Handling Your Request Please Try Again Or Contact The Software Developers In The About Section.", "Woa There", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Chrome.exe", "https://github.com/Brett-Tech-Networking");
            }
            catch
            {
                MessageBox.Show("Please Visit https://github.com/Brett-Tech-Networking", "Our Github", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Scanner_Click(object sender, EventArgs e)
        {

        }

        private void ubuntuButtonGray4_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowDialog();
            }
            catch
            {
                MessageBox.Show("We Were Unable Proccess That Right Now Please Try Again Later");
            }
        }

        private void ubuntuButtonGray2_Click(object sender, EventArgs e)
        {
            faderAlertBox1.Visible = true;
        }

        private void ubuntuButtonGray3_Click(object sender, EventArgs e)
        {
            faderAlertBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            help h = new help();
            h.Show();
        }

        private void ubuntuButtonGray1_Click(object sender, EventArgs e)
        {
            ProgressBar.Start();

            String tempFolder = Environment.ExpandEnvironmentVariables("%TEMP%");
            String prefetch = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%") + "\\Prefetch";
            EmptyFolderContents(tempFolder);
            EmptyFolderContents(prefetch);
        }

        private void EmptyFolderContents(string folderName)
        {
            foreach (var folder in Directory.GetDirectories(folderName))
            {
                try
                {
                    Directory.Delete(folder, true);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
            foreach (var file in Directory.GetFiles(folderName))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }

        }

        private void ProgressBar_Tick(object sender, EventArgs e)
        {
            faderProgressBar1.Value += 10;

            if (faderProgressBar1.Value == faderProgressBar1.Maximum)
            {
                faderProgressBar1.BackColor = Color.Red;
                faderAlertBox1.Visible = true;
                faderAlertBox1.Text = "All Temp Files Slowing Down Your Computer Have Been Deleted";


            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TaskmgrTimer_Tick(object sender, EventArgs e)
        {
            GetAllProcess();
            TaskmgrTimer.Stop();
        }

        private void ubuntuButtonGray5_Click(object sender, EventArgs e)
        {
            try
            {
                proc[faderListBox1.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could Not Stop Task","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            faderListBox1.Items.Clear();
            Process[] MyProcess = Process.GetProcesses();
            for (int i = 0; i < MyProcess.Length; i++)
                faderListBox1.Items.Add(MyProcess[i].ProcessName);
            
        }

        private void ubuntuButtonGray6_Click(object sender, EventArgs e)
        {
            using (frmRunTask frm = new frmRunTask())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
            }
        }

        private void cpuram_Click(object sender, EventArgs e)
        {

        }
    }
}

