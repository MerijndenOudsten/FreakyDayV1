using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Dashboard
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Inlognaam { get; set; }
        public string Wachtwoord { get; set; }

        public Gebruiker(string inlognaam, string wachtwoord)
        {
            this.Inlognaam = inlognaam;
            this.Wachtwoord = wachtwoord;
        }
    }
}
