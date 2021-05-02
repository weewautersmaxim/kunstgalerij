using System;
using System.Collections.Generic;

namespace kunstgalerij.DTO
{
    public class ArtworkDTO
    {
        public String Title { get; set; } 
        public int Year { get; set; }
        public int Price { get; set; }
        public string Imagename { get; set; }
        
        //extra DTO classes made for adding easy to read data, instead of everything
        public ArtworkArtistDTO artist { get; set; }
        public List<CategoryArtworksDTO> CategoryArtworks { get; set; }
    }
}