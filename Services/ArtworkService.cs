using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using kunstgalerij.DTO;
using kunstgalerij.Models;
using kunstgalerij.Repositories;
using Microsoft.AspNetCore.Http;

namespace kunstgalerij.Services
{
    public interface IArtworkService
    {
        Task<List<ArtworkDTO>> GetArtwork();
        //Task<ArtworkAddDTO> AddArtwork(ArtworkAddDTO artwork);
    }

    public class ArtworkService : IArtworkService
    {
        private IArtworkRepository _ArtworkRepository;
        private IMapper _mapper;

        public ArtworkService(IMapper mapper, IArtworkRepository ArtworkRepository)
        {
            _mapper = mapper;
            _ArtworkRepository = ArtworkRepository;
        }

         public async Task<List<ArtworkDTO>> GetArtwork()
        {
            Console.WriteLine(await _ArtworkRepository.GetArtwork());
            return _mapper.Map<List<ArtworkDTO>>(await _ArtworkRepository.GetArtwork());
        }
        // public async Task<ArtworkAddDTO> AddArtwork(ArtworkAddDTO artwork)
        // {
        //         byte[] bytes = System.Convert.FromBase64String(artwork.ImageEncoded);

        //         Artwork newArtwork = _mapper.Map<Artwork>(artwork);

        //         newArtwork.CategoryArtworks = new List<CategoryArtworks>();
        //         foreach (var categoryId in artwork.Categories)
        //         {
        //             newArtwork.CategoryArtworks.Add(new CategoryArtworks() { CategoryId = categoryId });
        //         }
        //         await _ArtworkRepository.AddArtwork(newArtwork);
        //         string fileName = $"{artwork.Imagename}.{artwork.Extension}";
        //         await _ArtworkRepository.AddArtworkImage(new ArtworkImage() { ArtworkId = newArtwork.ArtworkId, Name = fileName });

        //         return artwork;
        // }
    }
}
