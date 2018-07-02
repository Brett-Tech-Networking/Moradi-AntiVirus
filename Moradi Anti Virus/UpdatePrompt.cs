using System;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using System.Security.Authentication;
using System.Net;

namespace Moradi_Anti_Virus
{
    public partial class UpdatePrompt : MetroFramework.Forms.MetroForm
    {
        public const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
        public const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;

        public UpdatePrompt()
        {
            InitializeComponent();
        }

        private void Moradi_AntiVirus_Updater_Load(object sender, EventArgs e)
        {
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = Tls12;

            try
            {
                if (AutoUpdater.DownloadUpdate())
                {
                    Application.Exit();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
