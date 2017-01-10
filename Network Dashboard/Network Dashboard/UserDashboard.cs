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
    public partial class UserDashboard : Form
    {
        Gebruiker IngelogdeGebruiker;

        public UserDashboard(Gebruiker ingelogdeGebruiker)
        {
            InitializeComponent();
            this.IngelogdeGebruiker = ingelogdeGebruiker;

            
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_LoadGraph_Click(object sender, EventArgs e)
        {
            chart_Dataverbruik.Series[0].Points.AddXY(System.DateTime.Today, 5);
            
        }
    }
}
