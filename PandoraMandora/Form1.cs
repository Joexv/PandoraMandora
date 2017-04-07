using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using System.Reflection;
using System.IO;
using IniParser;
using IniParser.Model;

namespace PandoraMandora
{
    public partial class Form1 : Form
    {
        static bool Notifications = false;
        sshHandler madHax = new sshHandler();
        int Seconds = 2;
        bool ManualMode = false;
        bool ClosingBool = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            madHax.GUIConsoleWriter();
            madHax.readIP();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");

            #region Station Buttons

            station1.Text = madHax.dynStationName(1);
            station2.Text = madHax.dynStationName(2);
            station3.Text = madHax.dynStationName(3);
            station4.Text = madHax.dynStationName(4);
            station5.Text = madHax.dynStationName(5);
            station6.Text = madHax.dynStationName(6);
            station7.Text = madHax.dynStationName(7);
            station8.Text = madHax.dynStationName(8);
            station9.Text = madHax.dynStationName(9);
            station10.Text = madHax.dynStationName(10);

            #region Station Button ToolTips

            toolTip1.SetToolTip(station1, madHax.dynStationTip(1));
            toolTip1.SetToolTip(station2, madHax.dynStationTip(2));
            toolTip1.SetToolTip(station3, madHax.dynStationTip(3));
            toolTip1.SetToolTip(station4, madHax.dynStationTip(4));
            toolTip1.SetToolTip(station5, madHax.dynStationTip(5));
            toolTip1.SetToolTip(station6, madHax.dynStationTip(6));
            toolTip1.SetToolTip(station7, madHax.dynStationTip(7));
            toolTip1.SetToolTip(station8, madHax.dynStationTip(8));
            toolTip1.SetToolTip(station9, madHax.dynStationTip(9));
            toolTip1.SetToolTip(station10, madHax.dynStationTip(10));

            #endregion Station Button ToolTips

            #endregion Station Buttons
            #region MiniPlayer Color
            try
            {
                checkBox1.Checked = Convert.ToBoolean(data["Config"]["Notifications"]);
            }
            catch
            {
                checkBox1.Checked = false;
            }

            foreach (PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    comboBox1.Items.Add(prop.Name);
            }
            if (comboBox1.Items.Contains(data["Config"]["MiniPlayerColor"]) == true)
            {
                comboBox1.SelectedItem = data["Config"]["MiniPlayerColor"];
            }
            else if (comboBox1.Items.Contains(data["Config"]["MiniPlayerColor"]) == true
               || data["Config"]["MiniPlayerColor"] == ""
               || data["Config"]["MiniPlayerColor"] == null)
            {
                comboBox1.SelectedItem = "White";
                data["Config"]["MiniPlayerColor"] = "White";
                parser.WriteFile("Configuration.ini", data);
            }
            #endregion

            label1.Text = "Now Playing" + Environment.NewLine + madHax.SongInformation();
            SongTimer.RunWorkerAsync();           
        }

        #region Tool Strip Label
        private void RevertLabel_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(Seconds));
            toolStripStatusLabel1.Text = "....";
            Seconds = 2;
        }

        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Station Buttons
        private void station1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(1);
        }

        private void station2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(2);
        }

        private void station3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(3);
        }

        private void station4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(4);
        }

        private void station5_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(5);
        }

        private void station6_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(6);
        }

        private void station7_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(7);
        }

        private void station8_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(8);
        }

        private void station9_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(9);
        }

        private void station10_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = madHax.dynStation(10);
        }
        #endregion

        #region Settings Page
        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Configuration.ini");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ClosingBool = true;
            SongTimer.CancelAsync();
            ClosingBool = false;
            this.Hide();
            this.ShowInTaskbar = false;
            Form2 f2 = new Form2();          
            try
            {
                f2.Show();
            }
            catch
            {
                try
                {
                    f2.Activate();
                }
                catch
                {
                    MessageBox.Show("The Fuck?");
                }
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            madHax.rootSSH($"activator activate libactivator.lockscreen.clock.double-tap");
        }
        #endregion

        #region Now Playing
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Now Playing" + Environment.NewLine + madHax.SongInformation();
        }

        private void SongTimer_DoWork(object sender, DoWorkEventArgs e)
        {
                Thread.Sleep(TimeSpan.FromSeconds(12));              
        }

        private void SongTimer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ClosingBool == false)
            {
                try
                {
                    label1.Invoke((MethodInvoker)delegate
                    {
                        string TempString = label1.Text;
                        label1.Text = "Now Playing" + Environment.NewLine + madHax.SongInformation();
                        if (label1.Text != TempString && checkBox1.Checked == true)
                        {
                            ToastNotification();
                        }
                    });
                    if (ManualMode == false)
                    {
                        SongTimer.RunWorkerAsync();
                    }
                }
                catch{}
            }
        }
        private const String APP_ID = "Pandora Mandora";

        public void ToastNotification()
        {
            string Title = madHax.RepeatedResultSSH("media title", false);
            string Artist = madHax.RepeatedResultSSH("media artist", false);
            string Album = madHax.RepeatedResultSSH("media album", true);
            // Get a toast XML template
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            // Fill in the text elements
            XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
            stringElements[0].AppendChild(toastXml.CreateTextNode("Title: " + Title));
            //Path.GetFileNameWithoutExtension(label1.Text)
            stringElements[1].AppendChild(toastXml.CreateTextNode("Album: " + Album));
            stringElements[2].AppendChild(toastXml.CreateTextNode("Artist: " + Artist));

            // Specify the absolute path to an image
            //MessageBox.Show();
            XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
            Extract("PandoraMandora", Application.StartupPath, "Images", "icon.png");
            imageElements[0].Attributes.GetNamedItem("src").NodeValue = Application.StartupPath + @"\icon.png";

            // Create the toast and attach event listeners
            ToastNotification toast = new ToastNotification(toastXml);

            // Show the toast. Be sure to specify the AppUserModelId on your application's shortcut!
            ToastNotificationManager.CreateToastNotifier(APP_ID).Show(toast);
        }

        private static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            if (!File.Exists(outDirectory + resourceName))
            {
                Assembly assembly = Assembly.GetCallingAssembly();

                using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
                using (BinaryReader r = new BinaryReader(s))
                using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
                using (BinaryWriter w = new BinaryWriter(fs))
                    w.Write(r.ReadBytes((int)s.Length));
            }
        }

        #endregion

        #region Controls
        private void button1_Click(object sender, EventArgs e)
        {
            if (madHax.RemoveLineEndings(madHax.resultSSH("media appName", false)) == "Pandora")
            {
                Seconds = 3;
                toolStripStatusLabel1.Text = "Pandora Already open...";
                madHax.mobileSSH("media play");
            }
            else
            {
                Seconds = 3;
                toolStripStatusLabel1.Text = "Opening Pandora...";
                madHax.rootSSH($"activator send com.pandora");
                madHax.mobileSSH("media play");
                madHax.rootSSH($"activator send com.yeomans.programmablesms.Text-Message-6");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            madHax.mobileSSH("media play");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seconds = 5;
            toolStripStatusLabel1.Text = "Closing Pandora...";
            madHax.rootSSH($"activator send libactivator.system.first-springboard-page");
            madHax.mobileSSH("media stop");
            madHax.rootSSH($"activator send libactivator.system.clear-switcher");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Seconds = 3;
            toolStripStatusLabel1.Text = "Liked!";
            madHax.rootSSH($"activator activate libactivator.statusbar.tap.double.right");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManualMode = true;
            string tempString = label1.Text;
            Seconds = 3;
            toolStripStatusLabel1.Text = "Skipping song...";
            madHax.mobileSSH("media next");
            Thread.Sleep(4000);
            string tempString2 = "Now Playing" + Environment.NewLine + madHax.SongInformation();
            if (tempString == tempString2)
            {
                Seconds = 2;
                toolStripStatusLabel1.Text = "Loading...";
                Thread.Sleep(2000);
                tempString2 = "Now Playing" + Environment.NewLine + madHax.SongInformation();
                if (tempString == tempString2)
                {
                    Seconds = 2;
                    toolStripStatusLabel1.Text = "Loading times seem to be really bad right now!";
                }
            }
            else
            {
                label1.Text = tempString2;
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("Configuration.ini");
                if (Convert.ToBoolean(data["Config"]["Notifications"]) == true)
                {
                    ToastNotification();
                }
            }
            ManualMode = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManualMode = true;
            string tempString = label1.Text;
            Seconds = 3;
            toolStripStatusLabel1.Text = "Hated";
            madHax.rootSSH($"activator activate libactivator.statusbar.tap.double.left");
            Thread.Sleep(4000);
            string tempString2 = "Now Playing" + Environment.NewLine + madHax.SongInformation();
            if (tempString == tempString2)
            {
                Seconds = 2;
                toolStripStatusLabel1.Text = "Loading....";
                Thread.Sleep(2000);
                tempString2 = "Now Playing" + Environment.NewLine + madHax.SongInformation();
                if (tempString == tempString2)
                {
                    Seconds = 2;
                    toolStripStatusLabel1.Text = "Loading times seem to be really bad right now!";
                }
            }
            else
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("Configuration.ini");
                if (Convert.ToBoolean(data["Config"]["Notifications"]) == true)
                {
                    ToastNotification();
                }
                label1.Text = tempString2;
            }
            ManualMode = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Seconds = 0;
            toolStripStatusLabel1.Text = "Raising Volume...";
            madHax.mobileSSH("media vol+");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Seconds = 1;
            toolStripStatusLabel1.Text = "Muting...";
            madHax.mobileSSH("media vol0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Seconds = 0;
            toolStripStatusLabel1.Text = "Lowering Volume...";
            madHax.mobileSSH("media vol-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Seconds = 2;
            toolStripStatusLabel1.Text = "Low...";
            madHax.mobileSSH("media vol2");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Seconds = 2;
            toolStripStatusLabel1.Text = "Mid...";
            madHax.mobileSSH("media vol8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Seconds = 2;
            toolStripStatusLabel1.Text = "High...";
            madHax.mobileSSH("media vol14");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            madHax.mobileSSH("media pause");
        }
        #endregion

        private void RefreshSong_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Close();
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Notifications = true;
            }
            else if (checkBox1.Checked == false)
            {
                Notifications = false;
            }
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            data["Config"]["Notifications"] = Convert.ToString(Notifications);
            parser.WriteFile("Configuration.ini", data);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ToastNotification();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            string ColorString = comboBox1.SelectedItem.ToString();
            data["Config"]["MiniPlayerColor"] = ColorString;
            parser.WriteFile("Configuration.ini", data);
        }
    }
}
