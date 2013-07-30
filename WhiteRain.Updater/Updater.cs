/*
 * This file is part of the WhiteRain project (C) 2013 Finn Grimpe
 * Copyright 2013 Finn Grimpe, All Rights Reserved
 * 
 * Github:  https://github.com/finndev/WhiteRain/
 * Website: https://finn.lu/whiterain/
 * License: https://finn.lu/license
 *
 */

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

namespace WhiteRainNS.Updater
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
