using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Dashboard
{
    public class Dataverbruik
    {
        public int GebruikteUpload { get; set; }

        public int GebruikteDownload { get; set; }

        public Gebruiker currentGebruiker { get; set; }

        public string Datum { get; set; }


        public Dataverbruik(int gebruikteUpload, int gebruikteDownload, Gebruiker gebruiker, string datum)
        {
            this.GebruikteDownload = gebruikteDownload;
            this.GebruikteUpload = gebruikteUpload;
            this.currentGebruiker = gebruiker;
            this.Datum = datum;
        }
    }
}
