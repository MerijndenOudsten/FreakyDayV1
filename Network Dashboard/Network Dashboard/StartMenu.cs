using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Dashboard
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void btn_poortscanner_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poortscanner poortscanner = new Poortscanner();
            poortscanner.Show();
        }

        private void btn_Blacklisting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blacklisting blacklisting = new Blacklisting();
            blacklisting.Show();
        }

        private void btn_gebruikersrechten_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gebruikersrechten gebruikersrechten = new Gebruikersrechten();
            gebruikersrechten.Show();
        }
    }
}
