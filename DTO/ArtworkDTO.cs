using System;
using System.Collections.Generic;
using kunstgalerij.Models;

namespace kunstgalerij.DTO
{
    public class ArtworkDTO
    {
        public String Title { get; set; } 
        public int Year { get; set; }
        public int Price { get; set; }

        public ArtworkImage artworkImage { get; set; }
        
        //extra DTO classes made for adding easy to read data, instead of everything
        public ArtworkArtistDTO artist { get; set; }
        public List<CategoryArtworksDTO> CategoryArtworks { get; set; }
    }
}