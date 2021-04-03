using System;

namespace kunstgalerij.Models
{
    public class Kunstenaar
    {
        public Guid KunstenaarId { get; set; }
        public String Naam { get; set; }
        public String Voornaam { get; set; }
        public int Leeftijd { get; set; }
        public String geslacht { get; set; }
        public String Geboorteplaats { get; set; }
        public String Descriptie { get; set; }

    }
}
