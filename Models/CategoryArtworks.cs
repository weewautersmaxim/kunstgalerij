using System;

namespace kunstgalerij.Models
{
    public class CategoryArtworks
    {
        public int CategoryId { get; set; }
        public Guid ArtworkId { get; set; }        
        public Category Category { get; set; }
    }
}
