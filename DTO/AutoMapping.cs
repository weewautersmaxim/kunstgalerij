using AutoMapper;
using kunstgalerij.DTO;
using kunstgalerij.Models;

namespace Sneakers.API.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping() {
            CreateMap<Artist, ArtistDTO>();
            CreateMap<Artwork,ArtworkDTO>();
            //extra DTO for filtering data when get artwork is called.
            CreateMap<Artist,ArtworkArtistDTO>();
            CreateMap<ArtworkAddDTO, Artwork>();
            CreateMap<CategoryArtworks, CategoryArtworksDTO>();
            CreateMap<Category, CategoryDTO>();

        }
    }
}