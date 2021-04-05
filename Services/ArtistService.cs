using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using kunstgalerij.DTO;
using kunstgalerij.Models;
using kunstgalerij.Repositories;

namespace kunstgalerij.Services
{
    public interface IArtistService
    {
        Task<Artist> AddArtist(Artist artist);
        Task<List<ArtistDTO>> GetArtist();
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
        //opt moment gwn doorgeven (delete this later), moet nog toevoegen van artisten kunnen doen
        public async Task<List<ArtistDTO>> GetArtist()
        {
            return _mapper.Map<List<ArtistDTO>>(await _ArtistRepository.GetArtist());
        }

        public async Task<Artist> AddArtist(Artist artist)
        {
                await _ArtistRepository.AddArtist(artist);
                return artist;
        }
    }
}
