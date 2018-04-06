using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Moradi_Anti_Virus
{
    public partial class frmRunTask : Form
    {
        public frmRunTask()
        {
            InitializeComponent();
        }

        private void ubuntuButtonOrange1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ubuntuTextBox1.Text))
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = ubuntuTextBox1.Text;
                    proc.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
