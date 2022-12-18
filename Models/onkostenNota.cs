using System;
using Contentful.Core.Models;
using System.Collections.Generic;

namespace Case_study.Models
{
    public class onkostenNota
    {

        public onkostenNota()
        {
        }

        public onkostenNota(String naam, String voornaam, String bankrekeningnummer, String bic, DateTime datumVanOnkosten, String categorie, String anders,String onkosten, Double totaalBedrag, List<Asset> bijlage)
        //public onkostenNota(String voornaam)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this.bankrekeningnummer = bankrekeningnummer;
            this.bic = bic;
            this.datumVanOnkosten = datumVanOnkosten;
            this.categorie = categorie;
            this.anders = anders;
            this.onkosten = onkosten;
            this.totaalBedrag = totaalBedrag;
            this.bijlage = bijlage;           
            
        }
        public String naam { get; set; }

        public String voornaam { get; set; }

        public String bankrekeningnummer { get; set; }
        
        public String bic { get; set; }
        
        public DateTime datumVanOnkosten { get; set; }
        
        public String categorie { get; set; }

        public String anders { get; set; }

        public String onkosten { get; set; }

        public Double totaalBedrag { get; set; }

        public List<Asset> bijlage { get; set; }

    }
}
