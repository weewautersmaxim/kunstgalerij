using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class Artwork
    {
        public Guid ArtworkId { get; set; }
        public String Title { get; set; } 
        public int Year { get; set; }
        public int Price { get; set; }
        public string Imagename { get; set; }

        //1 to many relationship
        [JsonIgnore]
        public int ArtistId  { get; set; }
        public Artist artist { get; set; }
        
        //many on many relationship
        public List<CategoryArtworks> CategoryArtworks { get; set; }
    }
}
