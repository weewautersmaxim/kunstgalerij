using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class ArtworkImage
    {
        public int ArtworkImageId { get; set; }
        public string Name { get; set; }
        
        [JsonIgnore]
        public List<Artwork> artworks { get; set; }
        
    }
}
