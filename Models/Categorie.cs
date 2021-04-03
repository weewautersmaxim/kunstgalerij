using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class Categorie
    {
        public Guid CategorieId { get; set; }
        public String CategorieNaam { get; set; }

        //veel op veel relatie
        [JsonIgnore]
        public List<CategorieKunstwerken> CategorieKunstwerken { get; set; }
    }
}
