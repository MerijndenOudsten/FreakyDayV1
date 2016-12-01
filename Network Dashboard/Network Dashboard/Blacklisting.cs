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


namespace Network_Dashboard
{
    public partial class Blacklisting : Form
    {
        DbQueries DB = new DbQueries();
        
        

        public Blacklisting()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            lbl_scan.Visible = false;
            lbl_ipadres.Visible = false;

        }

        Thread mythread = null;
        public void scanfordevices(string subnet)
        {

            Ping myping;
            PingReply reply;
            IPAddress adress;
            IPHostEntry host;
            string macadress;

            for (int i = 1; i < 255; i++)
            {

                try
                {
                    pgb_scanning.Value = i;
                    string subnetn = "." + i.ToString();
                    myping = new Ping();
                    reply = myping.Send(subnet + subnetn);
                    lbl_ipadres.Text = subnet + "." + pgb_scanning.Value.ToString();
                    if (reply.Status == IPStatus.Success)
                    {
                        try
                        {
                            macadress = GetMacAddress(subnet + subnetn);
                            adress = IPAddress.Parse(subnet + subnetn);
                            host = Dns.GetHostEntry(adress);
                            lb_shownetworkdevices.Items.Add(macadress + "," + host.HostName.ToString());
                        }
                        catch (Exception ex)
                        {
                            EventLogging.LogMessageToFile(ex.Message);
                            lb_shownetworkdevices.Items.Add(subnet + subnetn + " " + "Hostname not found");
                        }

                    }
                }

                catch (Exception ex)
                {
                    EventLogging.LogMessageToFile(ex.Message);
                    MessageBox.Show("Er is iets fout gegaan tijdens het pingen rond het netwerk.");
                }

            }

            
        }
         private string GetMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                Process process = new Process();
                processStartInfo.FileName = "nbtstat";
                processStartInfo.RedirectStandardInput = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.Arguments = "-a " + ipAddress;
                processStartInfo.UseShellExecute = false;
                processStartInfo.CreateNoWindow = true;
                process = Process.Start(processStartInfo);

                int Counter = -1;

                while (Counter <= -1)
                {
                    Counter =
                    macAddress.Trim().ToLower().IndexOf("mac address", 0);
                    if (Counter > -1)
                    {
                        break;
                    }
                    macAddress = process.StandardOutput.ReadLine();
                }
                process.WaitForExit();
                macAddress = macAddress.Trim();
            }
            catch (Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
            }

            return macAddress;
        }


        private void btn_getalldevices_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_scan.Visible = true;
                lbl_ipadres.Visible = true;
                mythread = new Thread(() => scanfordevices(tb_subnet.Text));
                mythread.Start();


                if (mythread.IsAlive)
                {
                    btn_stopscan.Enabled = true;
                    btn_getalldevices.Enabled = false;
                    tb_subnet.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
                MessageBox.Show("Er is iets fout gegaan tijdens het starten van de Device scan.");
            }
        }

        private void btn_stopscan_Click(object sender, EventArgs e)
        {
            //mythread.Suspend();
            try
            {
                mythread.Suspend();
                btn_stopscan.Enabled = false;
                btn_getalldevices.Enabled = true;
                tb_subnet.Enabled = true;
            }
            catch(Exception ex)
            {
                EventLogging.LogMessageToFile(ex.Message);
            }
        }

        private void btn_blokkeerpoort_Click(object sender, EventArgs e)
        {
            string[] macadres = lb_shownetworkdevices.SelectedItem.ToString().Split(',');

            DB.VoegApparaatToe(macadres[0], macadres[1], Convert.ToInt32(cb_poortblokkeren.Text));
        }
    }
}


