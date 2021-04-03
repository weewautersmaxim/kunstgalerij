using System;

namespace kunstgalerij.Models
{
    public class CategorieKunstwerken
    {
        //in deze klas komen de id's van de veel op veel klassen samen
        public Guid CategorieId { get; set; }
        public int KunstwerkId { get; set; }        
        public Categorie Categorie { get; set; }
    }
}
