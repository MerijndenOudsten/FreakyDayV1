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

        }

        Thread mythread = null;
        public void scanfordevices(string subnet)
        {
            Ping myping;
            PingReply reply;
            IPAddress adress;
            IPHostEntry host;

            for (int i = 1; i < 255; i++)
            {
                try
                {
                    pgb_scanning.Value = i;
                    string subnetn = "." + i.ToString();
                    myping = new Ping();
                    reply = myping.Send(subnet + subnetn);

                    if (reply.Status == IPStatus.Success)
                    {
                        try
                        {
                            adress = IPAddress.Parse(subnet + subnetn);
                            host = Dns.GetHostEntry(adress);

                            lb_shownetworkdevices.Items.Add(subnet + subnetn + host.HostName.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Couldn't retrieve hostname for " + subnet + subnetn, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (PingException e)
                {
                    MessageBox.Show(e.ToString());
                }



            }

        }
        private void btn_getalldevices_Click(object sender, EventArgs e)
        {
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

