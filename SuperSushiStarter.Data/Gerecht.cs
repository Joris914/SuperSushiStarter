using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperSushi.Data
{
    public class Gerecht
    {
        public int Id { get; set; }
        public Soort Soort { get; set; }
        public string Omschrijving {get;set;}
        public decimal Prijs { get; set; }
    }

    public enum Soort { 
        Vis,
        Vlees,
        Vega,
        Insect
    }
}
