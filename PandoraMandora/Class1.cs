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
using System.Net;
using System.Net.Sockets;

namespace PandoraMandora
{
    class sshHandler
    {
        public static string ipAddress;
        public static string password;
        public static string username;

        public void mobileSSH(string Command)
        {
            Cursor.Current = Cursors.WaitCursor;
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
            Cursor.Current = Cursors.Default;
        }

        public void rootSSH(string Command)
        {
            Cursor.Current = Cursors.WaitCursor;
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
            Cursor.Current = Cursors.Default;
        }

        public string resultSSH(string Command, bool Root)
        {
            Cursor.Current = Cursors.WaitCursor;
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
            Cursor.Current = Cursors.Default;
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
            Cursor.Current = Cursors.WaitCursor;
            WriteLine("Checking to see if Config file exists...");
            if (!File.Exists(Application.StartupPath + @"/Configuration.ini"))
            {
                WriteLine("it Doesn't creating one...");
                using (StreamWriter sw = File.CreateText(Application.StartupPath + @"/Configuration.ini"))
                {
                }
                WriteLine("Created. Adding Temporary content...");
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("Configuration.ini");
                string Temp = "Temp";
                data["Config"]["IP"] = Temp;
                parser.WriteFile("Configuration.ini", data);

                data["Config"]["username"] = "root";
                parser.WriteFile("Configuration.ini", data);

                data["Config"]["password"] = "alpine";
                parser.WriteFile("Configuration.ini", data);

                ipAddress = data["Config"]["IP"];
                username = data["Config"]["username"];
                password = data["Config"]["password"];
                MessageBox.Show("The SSH wont connect as it has no IP address or usernames to work off. So restart the program after changing it.");
            }
            else
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("Configuration.ini");

                ipAddress = data["Config"]["IP"];
                username = data["Config"]["username"];
                password = data["Config"]["password"];
            }
            Cursor.Current = Cursors.Default;
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int dwProcessId);

        private const int ATTACH_PARENT_PROCESS = -1;

        StreamWriter _stdOutWriter;

        // this must be called early in the program
        public void GUIConsoleWriter()
        {
            // this needs to happen before attachconsole.
            // If the output is not redirected we still get a valid stream but it doesn't appear to write anywhere
            // I guess it probably does write somewhere, but nowhere I can find out about
            var stdout = Console.OpenStandardOutput();
            _stdOutWriter = new StreamWriter(stdout);
            _stdOutWriter.AutoFlush = true;

            AttachConsole(ATTACH_PARENT_PROCESS);
        }

        public void WriteLine(string line)
        {
            _stdOutWriter.WriteLine(line);
            Console.WriteLine(line);
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
