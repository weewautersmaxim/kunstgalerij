using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using kunstgalerij.DTO;
using kunstgalerij.Models;
using kunstgalerij.Repositories;
using Microsoft.AspNetCore.Http;
using Sneakers.API.Services;

namespace kunstgalerij.Services
{
    public interface IArtworkService
    {
        Task<List<ArtworkDTO>> GetArtworks();
        Task<ArtworkAddDTO> AddArtwork(ArtworkAddDTO artwork);
        Task<List<Artwork>> GetArtwork(int artistId);
    }

    public class ArtworkService : IArtworkService
    {
        private IBlobService _blobService;
        private IArtworkRepository _ArtworkRepository;
        private IMapper _mapper;

        public ArtworkService(IMapper mapper, IArtworkRepository ArtworkRepository, IBlobService blobService)
        {
            _mapper = mapper;
            _ArtworkRepository = ArtworkRepository;
            _blobService = blobService;
        }

         public async Task<List<ArtworkDTO>> GetArtworks()
        {
            return _mapper.Map<List<ArtworkDTO>>(await _ArtworkRepository.GetArtworks());
        }
        public async Task<ArtworkAddDTO> AddArtwork(ArtworkAddDTO artwork)
        {
                string containerName = "maximweewauters";
                byte[] bytes = System.Convert.FromBase64String(artwork.ImageEncoded);

                Artwork newArtwork = _mapper.Map<Artwork>(artwork);

                newArtwork.CategoryArtworks = new List<CategoryArtworks>();
                foreach (var categoryId in artwork.Categories)
                {
                    newArtwork.CategoryArtworks.Add(new CategoryArtworks() { CategoryId = categoryId });
                }
                await _ArtworkRepository.AddArtwork(newArtwork);
                string fileName = $"{artwork.Imagename}.{artwork.Extension}";
                await _blobService.UploadByteArray(containerName, bytes, fileName);
                newArtwork.Imagename = fileName;

                return artwork;
        }

        public async Task<List<Artwork>> GetArtwork(int artistId){
            try
            {
                return await _ArtworkRepository.GetArtwork(artistId);
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
