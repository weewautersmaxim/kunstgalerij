using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using kunstgalerij.DTO;
using kunstgalerij.Models;
using kunstgalerij.Repositories;

namespace kunstgalerij.Services
{
    public interface IArtworkService
    {
        Task<List<ArtworkDTO>> GetArtwork();
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
            return _mapper.Map<List<ArtworkDTO>>(await _ArtworkRepository.GetArtwork());
        }
    }
}
