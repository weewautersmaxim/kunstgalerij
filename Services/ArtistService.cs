using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using kunstgalerij.Models;
using kunstgalerij.Repositories;

namespace kunstgalerij.Services
{
    public interface IArtistService
    {
        Task<List<Artist>> GetArtist();
    }

    public class ArtistService : IArtistService
    {
        private IArtistRepository _ArtistRepository;
        private IMapper _mapper;

        public ArtistService(IMapper mapper, IArtistRepository ArtistRepository)
        {
            _mapper = mapper;
            _ArtistRepository = ArtistRepository;
        }
        //opt moment gwn doorgeven (delete this later)
        public async Task<List<Artist>> GetArtist()
        {
            return await _ArtistRepository.GetArtist();
        }
    }
}
