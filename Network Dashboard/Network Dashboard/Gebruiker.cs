using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Dashboard
{
    public class Gebruiker
    {
        public string Id { get; set; }
        public string Inlognaam { get; set; }
        public string Wachtwoord { get; set; }
        public string Recht { get; set; }

        public Gebruiker(string id, string inlognaam, string wachtwoord, string recht)
        {
            this.Id = id;
            this.Inlognaam = inlognaam;
            this.Wachtwoord = wachtwoord;
            this.Recht = recht;
        }
    }
}
