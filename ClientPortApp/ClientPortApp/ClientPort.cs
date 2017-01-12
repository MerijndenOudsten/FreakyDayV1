using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace ClientPortApp
{
    public partial class ClientPort : Form
    {
        DB database = new DB();
        Apparaat apparaat;
        int porttoblock;
        int block;
        string macadres;

        public ClientPort()
        {
            InitializeComponent();
            Portblocker();
        }

        private void Portblocker()
        {
            string ipadress = GetLocalIPAddress();
            apparaat = new Apparaat(GetMacAddress(ipadress));
            apparaat = database.GetBlockedPort(apparaat.macadres);
            porttoblock = apparaat.blockedport;
            block = apparaat.block;
            macadres = apparaat.macadres;
            string stdout, stderr;
            if (block == 0)
            {
                RunShellCommand(
            "netsh.exe",
            String.Format("advfirewall firewall delete rule name=\"{0}\" dir=out protocol={1} remoteport={2}",
            "Block Port 80",
            "TCP",
            porttoblock),
            out stdout,
            out stderr);
                database.DeleteRow(apparaat.macadres);
            }
            else
            {
                RunShellCommand(
            "netsh.exe",
            String.Format("advfirewall firewall add rule name=\"{0}\" dir=out action=block protocol={1} remoteport={2}",
            "Block Port 80",
            "TCP",
            porttoblock),
            out stdout,
            out stderr);
            }

        }
        private int RunShellCommand(string command, string parms, out string stdout, out string stderr, bool waitForCompletion = true)
        {
            ProcessStartInfo psi = new ProcessStartInfo(command);
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.CreateNoWindow = true;
            Process proc = Process.Start(psi);
            System.IO.StreamWriter sw = proc.StandardInput;
            System.IO.StreamReader sr = proc.StandardOutput;
            System.IO.StreamReader se = proc.StandardError;
            sw.WriteLine(parms);
            sw.Close();
            stdout = sr.ReadToEnd();
            stderr = se.ReadToEnd();
            if (waitForCompletion)
                proc.WaitForExit();
            return proc.ExitCode;
        }
        private string GetMacAddress(string ipAddress)
        {
            string filename = "c:/users/Remco/nbtstatoutput.txt";
            string line = string.Empty;
            string macAddress = string.Empty;
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                Process process = new Process();
                processStartInfo.FileName = "nbtstat";
                processStartInfo.RedirectStandardInput = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.Arguments = "-a " + ipAddress + " > nbtstatoutput.txt";
                processStartInfo.UseShellExecute = false;
                processStartInfo.CreateNoWindow = true;
                process = Process.Start(processStartInfo);
                using (StreamReader file = new StreamReader(filename))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.Contains("="))
                        {
                            string[] lines = line.Split();
                            macAddress = lines[7];
                        }

                    }
                }
                process.WaitForExit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return macAddress = " B8-88-E3-9B-70-49";
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void ClientPort_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Minimized;
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }

}
