using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Dashboard
{
    public class Advies
    {

        public string AdviesNaam { get; set; }

        private string advies, dgAdviesNaam, blAdviesNaam, grAdviesNaam, psAdviesNaam;

        public Advies(string adviesNaam)
        {
            this.AdviesNaam = adviesNaam;
            dgAdviesNaam = AdviesNaam;
            blAdviesNaam = AdviesNaam;
            grAdviesNaam = AdviesNaam;
            psAdviesNaam = AdviesNaam;
        }

        public string GetAdvies ()
        {
            switch(dgAdviesNaam)
            {
                case "dgHelpStart":
                    advies = "Wanneer u op de knop Start drukt worden de internetgegevens van het hierboven gekozen interface weergegeven.";
                    return advies;
                case "dgHelpStop":
                    advies = "Wanneer u op de knop Stop drukt wordt het behalen van internetgegevens gestopt.";
                    return advies;
                case "dgHelpCombo":
                    advies = "Dit menu geeft een lijst weer van alle internet interfaces waar uw PC mee te maken heeft.";
                    return advies;
                case "dgHelpSnelheid":
                    advies = "Hier wordt de snelheid van het gekozen interface weergegeven.";
                    return advies;
                case "dgHelpUpload":
                    advies = "Hier wordt de actuele gebruikte bandbreedte van het uploaden van deze PC weergegeven.";
                    return advies;
                case "dgHelpDownload":
                    advies = "Hier wordt de actuele gebruikte bandbreedte van het downloaden van deze PC weergegeven.";
                    return advies;
                default:
                    return "";
            }
            
        }
    }
}
