using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public String Name { get; set; }
        public String FirstName { get; set; }
        public int Age { get; set; }
        public String Gender { get; set; }
        public String Birthplace { get; set; }
        public String description { get; set; }
        [JsonIgnore]
        public List<Artwork> artworks { get; set; }

    }
}
