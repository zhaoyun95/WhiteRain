using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whiteRain.Updater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Updater_Load(object sender, EventArgs e)
        {
             localVersion.Text = AssemblyName.GetAssemblyName("WhiteRain.dll").Version.ToString();

            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += (s, E) =>
                {
                    StatusBar.Value = E.ProgressPercentage;
                };
                wc.DownloadFileCompleted += (s, E) =>
                {
                    newestVersion.Text = AssemblyName.GetAssemblyName("WhiteRain.dll").Version.ToString();
                    MessageBox.Show("Update completed. You can run the bot now.");
                };
                wc.DownloadFileAsync(new Uri("https://finn.lu/update/whiterain.php?action=dl"), string.Format("{0}/{1}", Application.StartupPath, "WhiteRain.dll"));
            }
        }
    }
}
