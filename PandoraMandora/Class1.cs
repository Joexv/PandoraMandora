using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.Windows.Forms;
using IniParser.Model;
using IniParser;
using System.IO;

namespace PandoraMandora
{
    class sshHandler
    {
        public static string ipAddress;
        public static string password;
        public static string username;

        public void mobileSSH(string Command)
        {
            try
            {
                using (var client = new SshClient(ipAddress, "mobile", "alpine"))
                {
                    client.Connect();
                    client.RunCommand(Command);
                    client.Disconnect();
                }
            }
            catch
            {
                MessageBox.Show("Error on connecting to ssh");
            }
        }

        public void rootSSH(string Command)
        {
            try
            {
                using (var client = new SshClient(ipAddress, "root", password))
                {
                    client.Connect();
                    client.RunCommand(Command);
                    client.Disconnect();
                }
            }
            catch
            {
                MessageBox.Show("Error on connecting to ssh");
            }
        }

        public string resultSSH(string Command, bool Root)
        {
            readIP();
            string Result = "null";
            try
            {
                if (Root == true)
                {
                    using (var client = new SshClient(ipAddress, "root", password))
                    {
                        client.Connect();
                        var cmd = client.RunCommand(Command);
                        Result = cmd.Result;
                        client.Disconnect();
                    }
                }
                else
                {
                    using (var client = new SshClient(ipAddress, "mobile", "alpine"))
                    {
                        client.Connect();                      
                        var cmd = client.RunCommand(Command);
                        Result = cmd.Result;
                        client.Disconnect();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error on connecting to ssh");
            }
            return Result;
        }

        public void activatorSSH(string Command)
        {
            rootSSH($"activator send libactivator." + Command);
        }

        public string dynStation(int ButtonNum)
        {
            playStation(dynStationID(ButtonNum));
            return "Playing " + dynStationName(ButtonNum) + "....";
        }

        public string dynStationID(int ButtonNum)
        {
            string StationID = "";
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            StationID = data["StationID"]["Button" + ButtonNum];

            return StationID;
        }

        public string dynStationName(int ButtonNum)
        {
            string StationName = "";
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            StationName = data["StationName"]["Button" + ButtonNum];

            return StationName;
        }

        public string dynStationTip(int ButtonNum)
        {
            string StationTip = "";
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            StationTip = data["StationTip"]["Button" + ButtonNum].Replace("/n", "\r\n");

            return StationTip;
        }

        public void playStation(string Station)
        {
            rootSSH("uiopen pandora:/createStation?stationId=" + Station);
        }

        public void readIP()
        {
            if (!File.Exists(Application.StartupPath + @"/Configuration.ini"))
            {
                using (StreamWriter sw = File.CreateText(Application.StartupPath + @"/Configuration.ini"))
                {
                }
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("Configuration.ini");

                string Temp = "Temp";
                data["Config"]["username"] = Temp;
                parser.WriteFile("Configuration.ini", data);

                data["Config"]["password"] = Temp;
                parser.WriteFile("Configuration.ini", data);

                data["Config"]["IP"] = Temp;
                parser.WriteFile("Configuration.ini", data);

                ipAddress = data["Config"]["IP"];
                username = data["Config"]["username"];
                password = data["Config"]["password"];
            }
            else
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("Configuration.ini");

                ipAddress = data["Config"]["IP"];
                username = data["Config"]["username"];
                password = data["Config"]["password"];
            }
        }

        public string RemoveLineEndings(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return value;
            }
            string lineSeparator = ((char)0x2028).ToString();
            string paragraphSeparator = ((char)0x2029).ToString();

            return value.Replace("\r\n", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty).Replace(lineSeparator, string.Empty).Replace(paragraphSeparator, string.Empty);
        }

    }
}
