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
using System.IO;
using System.Threading;

namespace XenonLauncher
{
    public partial class XenonLauncher : Form
    {
        public XenonLauncher()
        {
            InitializeComponent();
        }
        
        string currentDirectory = Directory.GetCurrentDirectory();
        int r = 255, g = 0, b = 0;

        private void XenonLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                Process.Start(currentDirectory + "\\MC-ON.reg");
                Thread.Sleep(3000);
                try
                {
                    Process.Start(currentDirectory + "\\on.bat");
                }
                catch(Exception onWrongSpot)
                {
                    MessageBox.Show("on in wrong spot", "error");
                }
            }
            catch (Exception mconWrongSpot)
            {
                MessageBox.Show("mc on in wrong spot", "error");
            }

        }
        

        private void XenonLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Process.Start(currentDirectory + "\\MC-OFF.reg");
                Thread.Sleep(3000);
                try
                {
                    Process.Start(currentDirectory + "\\off.bat");
                }
                catch (Exception offWrongSpot)
                {
                    MessageBox.Show("off in wrong spot", "error");
                }
            }
            catch (Exception mcoffWrongSpot)
            {
                MessageBox.Show("mc off in wrong spot", "error");
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            Process.Start("Minecraft://");
        }

        private void RGBon_CheckedChanged(object sender, EventArgs e)
        {
            if(RGBon.Checked)
            {
                RGBtimer.Start();
            }
            else
            {
                RGBtimer.Stop();
                this.BackColor = SystemColors.ActiveCaptionText;
            }
        }

        private void StopRuntime_Click(object sender, EventArgs e)
        {
            Process.Start(currentDirectory + "\\EndRuntimeBroker.bat");
            Thread.Sleep(3000);
            Process.Start(currentDirectory + "\\StartRuntimeBroker.bat");
        }

        private void RGBtimer_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(r, g, b);
            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0)
            {
                g--;
                b++;
            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }
        }
    }
}
