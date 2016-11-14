﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;

namespace Network_Dashboard
{
    public partial class Blacklisting : Form
    {

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

            for (int i = 167; i < 255; i++)
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
                            lb_shownetworkdevices.Items.Add(macadress + " " + host.HostName.ToString());
                        }
                        catch
                        {
                            lb_shownetworkdevices.Items.Add(subnet + subnetn + " " + "Hostname not found");
                        }

                    }
                }
                catch (PingException e)
                {
                    MessageBox.Show(e.ToString());
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
            catch (Exception e)
            {

                Console.WriteLine("Failed because:" + e.ToString());
            }

            return macAddress;
        }
        private void btn_getalldevices_Click(object sender, EventArgs e)
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

        private void btn_stopscan_Click(object sender, EventArgs e)
        {
            mythread.Suspend();
            btn_stopscan.Enabled = false;
            btn_getalldevices.Enabled = true;
            tb_subnet.Enabled = true;
        }
    }
}

