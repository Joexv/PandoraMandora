using IniParser;
using IniParser.Model;
using Renci.SshNet;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PandoraMandora
{
    public partial class Form2 : Form
    {
        private static string ipAddress;
        private static string password;
        private static string username;
        private static int Volume = 0;
        bool ManualMode = false;

        private Form opener;
        sshHandler madHax = new sshHandler();

        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
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

            this.BackColor = Color.FromName(data["Config"]["MiniPlayerColor"]);
            label1.BackColor = Color.FromName(data["Config"]["MiniPlayerColor"]);
            if (label1.BackColor == Color.FromName("White"))
            {
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
            this.ShowInTaskbar = false;
            Form1 frm = new Form1();
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
            label1.Invoke((MethodInvoker)delegate
            {
                label1.Text = "Now Playing" + Environment.NewLine + madHax.resultSSH("media title", false);
            });
            if (ManualMode == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
