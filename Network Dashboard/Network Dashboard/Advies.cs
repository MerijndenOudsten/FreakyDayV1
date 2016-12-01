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
        

        public Advies(string adviesNaam)
        {
            this.AdviesNaam = adviesNaam;
        }

        public string GetAdvies ()
        {
            string advies;
            switch(AdviesNaam)
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
                case "blHelpApparaten":
                    advies = "In deze lijst worden alle in het subnet gevonden apparaten weergegeven via MAC-adres en de naam van het apparaat. De applicatie kan niet altijd het MAC-adres opgehaald krijgen. In plaats daarvan komt er een IP-adres te staan.";
                    return advies;
                case "blHelpSubnet":
                    advies = "In deze textbox kan met de eerste drie delen van uw actuele IP-adres (bijv. 10.10.10.x zonder de x te gebruiken) gezocht worden op apparaten in uw netwerk.";
                    return advies;
                case "blHelpStart":
                    advies = "Wanneer u op de knop Startscan drukt wordt het scannen van uw actuele subnet gestart. U kunt de actualiteit van de scan volgen via de progressiebar.";
                    return advies;
                case "blHelpStop":
                    advies = "Wanneer u op de knop Stopscan drukt wordt het scanne van uw actuele subnet gestopt.";
                    return advies;
                case "blHelpBlokkeer":
                    advies = "Nadat u een apparaat en een netwerkpoort gekozen heeft om te blokkeren kunt u op deze knop drukken om het definitief te maken. LET OP!! Het is gevaarlijk om verscheidene poorten te blokkeren. De applicatie heeft geen toegang tot het deblokkeren van deze poorten. Neem contact op met een expert als u geen toegang meer heeft tot het internet.";
                    return advies;
                case "blHelpPoort":
                    advies = "Via dit menu kiest u de poort die u op het geselecteerde apparaat wilt blokkeren.";
                    return advies;
                case "grHelpGebruikers":
                    advies = "In deze lijst worden alle gebruikersaccounts in uw applicatie weergegeven.";
                    return advies;
                case "grHelpKeuze":
                    advies = "Via dit menu kunt u de keuze maken voor het recht dat u aan een account wilt toekennen.";
                    return advies;
                case "grHelpVerander":
                    advies = "Wanneer u een gebruiker en daarvoor een nieuwe recht heeft geselecteerd, kunt u met deze knop het nieuwe recht toekennen.";
                    return advies;
                case "psHelpPoortscan":
                    advies = "Met de poortscanner kunt u zien of verschillende netwerkpoorten op uw PC open of gesloten zijn.";
                    return advies;
                case "smHelpIngelogd":
                    advies = "Hier wordt de gebruikersnaam van het ingelogde account weergegeven, zodat u weet met welk account u bent ingelogd.";
                    return advies;
                case "smHelpPoort":
                    advies = "Wilt u weten welke netwerkpoorten er open staan op uw PC? Met deze knop wordt u naar het poortscan gedeelte van de applicatie verwezen.";
                    return advies;
                case "smHelpBlacklist":
                    advies = "Met blacklisting kunt u alle apparaten op uw actuele netwerk scannen en deze ook de toegang blokkeren.";
                    return advies;
                case "smHelpGebruikersrecht":
                    advies = "In het deel gebruikersrechten kunt u alle gebruikers in uw huishouden bekijken en van deze gebruikers de rechten veranderen.";
                    return advies;
                case "smHelpData":
                    advies = "Met datagebruik kunt u uw datagebruik van uw PC bekijken.";
                    return advies;
                default:
                    return "";
            }
            
        }
    }
}
