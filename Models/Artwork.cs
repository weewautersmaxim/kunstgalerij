using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class Artwork
    {
        public Guid ArtworkId { get; set; }
        public String Title { get; set; }

        //1 to many relation, 1 artist can make multiple works of art. 
        //1 work of art can not be made with multiple artists.
        [JsonIgnore]
        public Guid ArtistId { get; set; }
        public Artist Artist { get; set; }
        
        public int Year { get; set; }
        public int Price { get; set; }
        
        //many on many relationship
        public List<CategoryArtworks> CategoryArtwork { get; set; }
    }
}
