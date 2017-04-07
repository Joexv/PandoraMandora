using IniParser;
using IniParser.Model;
using Renci.SshNet;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PandoraMandora
{
    public partial class Form2 : Form
    {
        public static string ipAddress;
        public static string password;
        public static string username;
        public static string MobileUser;
        public static string MobilePass;

        bool ManualMode = false;

        bool ClosingBool = false;

        sshHandler madHax = new sshHandler();
        Form1 frm = new Form1();

        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public Form2()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private void Form2_Load(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");

            ipAddress = data["Config"]["IP"];
            username = data["Config"]["username"];
            password = data["Config"]["password"];
            MobilePass = data["Config"]["mobilePass"];
            MobileUser = data["Config"]["mobileUser"];

            try
            {
                this.BackColor = Color.FromName(data["Config"]["MiniPlayerColor"]);
                label1.BackColor = Color.FromName(data["Config"]["MiniPlayerColor"]);
                if (label1.BackColor == Color.FromName("White"))
                {
                    label1.ForeColor = Color.Black;
                }
            }
            catch
            {
                MessageBox.Show("There was somethign wrong with the colors set for the mini player. Please try a different color.");
                this.BackColor = Color.White;
                label1.BackColor = Color.White;
                label1.ForeColor = Color.Black;
            }

            label1.Text = "Now Playing" + Environment.NewLine + madHax.resultSSH("media title", false);
            backgroundWorker1.RunWorkerAsync();
        }

        private void GetVolume()
        {
            madHax.rootSSH("media getVol");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            madHax.rootSSH($"activator activate libactivator.statusbar.tap.double.right");
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Now Playing" + Environment.NewLine + madHax.resultSSH("media title", false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            madHax.mobileSSH("media vol-");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClosingBool = true;
            backgroundWorker1.CancelAsync();
            //this.ShowInTaskbar = false;
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            madHax.mobileSSH("media play");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            madHax.mobileSSH("media pause");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            madHax.mobileSSH("media next");
            Thread.Sleep(4000);
            label1.Text = "Now Playing" + Environment.NewLine + madHax.resultSSH("media title", false);
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            if (Convert.ToBoolean(data["Config"]["Notifications"]) == true)
            {
                frm.ToastNotification();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            madHax.mobileSSH("media vol+");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            madHax.rootSSH($"activator activate libactivator.statusbar.tap.double.left");
            Thread.Sleep(4000);
            label1.Text = "Now Playing" + Environment.NewLine + madHax.resultSSH("media title", false);
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            if (Convert.ToBoolean(data["Config"]["Notifications"]) == true)
            {
                frm.ToastNotification();
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(12));
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (ClosingBool == false)
            {
                try
                {
                    label1.Invoke((MethodInvoker)delegate
                    {
                        var parser = new FileIniDataParser();
                        IniData data = parser.ReadFile("Configuration.ini");
                        string TempString = label1.Text;
                        label1.Text = "Now Playing" + Environment.NewLine + madHax.resultSSH("media title", false);
                        if (label1.Text != TempString && Convert.ToBoolean(data["Config"]["Notifications"]) == true)
                        {
                            frm.ToastNotification();
                        }
                    });
                    if (ManualMode == false)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                catch
                {

                }
            }
            else
            {
                ClosingBool = false;
            }
        }
    }
}
