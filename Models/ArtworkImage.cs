using System;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class ArtworkImage
    {
        public Guid ArtworkImageId { get; set; }
        public string Name { get; set; }
        
        [JsonIgnore]
        public Guid ArtworkId { get; set; }
    }
}
