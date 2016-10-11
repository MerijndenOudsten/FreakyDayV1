using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;


namespace Network_Dashboard
{
    public class Portscan
    {
        private int Port;

        public Portscan(int port)
        {
            this.Port = port;
        }

        public string GetLocalIPAddress()
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
        public string StartScan()
        {
            for (int CurrPort = Port; CurrPort <= Port; CurrPort++)
            {
                TcpClient TcpScan = new TcpClient();
                try
                {
                    TcpScan.Connect(GetLocalIPAddress(), CurrPort);
                    if (TcpScan.Connected)
                    {
                        return "open";
                    }
                    else
                    {
                        return "closed";
                    }
                }
                catch(Exception ex)
                {
                   Console.WriteLine(ex.Message);
                }

            }
            return "closed";
        }
    }
}
