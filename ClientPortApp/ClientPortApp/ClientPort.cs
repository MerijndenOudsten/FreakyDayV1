using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace ClientPortApp
{
    public partial class ClientPort : Form
    {
        public ClientPort()
        {
            InitializeComponent();
        }

        private void btn_BlockPort_Click(object sender, EventArgs e)
        {
            string stdout, stderr;
            RunShellCommand(
     "netsh.exe",
     String.Format("advfirewall firewall add rule name=\"{0}\" dir=out action=block protocol={1} remoteport={2} remoteip={3}",
     "Block Port 80",
     "TCP",
     80,
     "192.168.1.1"),
     out stdout,
     out stderr);
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

    }
}
