using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class Kunstwerk
    {
        public Guid KunstwerkId { get; set; }
        public String Titel { get; set; }

        //1 op veel relatie, 1 kunstenaar kan meerdere kunstwerken maken. 
        //1 kunstwerk kan niet door meerdere kunstenaren gemaakt zijn.
        [JsonIgnore]
        public Guid KunstenaarId { get; set; }
        public Kunstenaar Kunstenaar { get; set; }

        public int Jaar { get; set; }
        public String Categorie { get; set; }
        public int Prijs { get; set; }
        
        //veel op veel relatie met categorie
        public List<CategorieKunstwerken> CategorieKunstwerken { get; set; }
    }
}
