using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class Artwork
    {
        public Guid ArtworkId { get; set; }
        public String Title { get; set; }
        //foreign key
        [JsonIgnore]
        public int ArtistId  { get; set; }
        public Artist artist { get; set; }
        
        public int Year { get; set; }
        public int Price { get; set; }
        
        // //many on many relationship
        // public List<CategoryArtworks> CategoryArtwork { get; set; }
    }
}
