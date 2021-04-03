using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace kunstgalerij.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }

        //many to many relationship
        [JsonIgnore]
        public List<CategoryArtworks> CategoryArtworks { get; set; }
    }
}
