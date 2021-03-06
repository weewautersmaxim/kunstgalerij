using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kunstgalerij.DTO;
using kunstgalerij.Models;
using kunstgalerij.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace kunstgalerij.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api")]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _ArtistService;
        private readonly IArtworkService _ArtworkService;
        private readonly ICategoryService _CategoryService;
        private readonly ILogger<ArtistController> _logger;

        //image test (ook in ctor)
        public static IWebHostEnvironment _environment;

        public ArtistController(ILogger<ArtistController> logger,IArtistService ArtistService, IArtworkService ArtworkService, ICategoryService CategoryService, IWebHostEnvironment environment)
        {
            _logger = logger;
            _ArtistService = ArtistService;
            _ArtworkService = ArtworkService;
            _CategoryService = CategoryService;
            _environment = environment;
        }

        [AllowAnonymous]
        //artists
        [HttpGet]
        [Route("artists")]
        public async Task<ActionResult<List<Artist>>> GetArtists()
        {
            try{
                return new OkObjectResult(await _ArtistService.GetArtists());
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        //deze wordt beveiligd door Client credentials
        [HttpGet]
        [Route("artist/{name}")]
        public async Task<ActionResult<List<Artist>>> GetArtist(string name)
        {
            try{
                return new OkObjectResult(await _ArtistService.GetArtist(name));
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("artists")]
         public async Task<ActionResult<Artist>> AddArtist(Artist artist)
        {
            try{
                return new OkObjectResult(await _ArtistService.AddArtist(artist));
            }
            catch(Exception){
                return new StatusCodeResult(500);
            }
        }

        //artworks
        [AllowAnonymous]
        [HttpGet]
        [Route("artworks")]
        public async Task<ActionResult<List<ArtworkDTO>>> GetArtworks()
        {
            try{
                return new OkObjectResult(await _ArtworkService.GetArtworks());
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        //deze wordt beveiligd door client credentials
        [HttpGet]
        [Route("artwork/{artistId}")]
        public async Task<ActionResult<List<Artwork>>> GetArtwork(int artistId)
        {
            try{
                return new OkObjectResult(await _ArtworkService.GetArtwork(artistId));
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("artworks")]
        public async Task<ActionResult<ArtworkAddDTO>> AddArtwork(ArtworkAddDTO artwork)
        {
            try{
                return new OkObjectResult(await _ArtworkService.AddArtwork(artwork));
            }
            catch(Exception){
                return new StatusCodeResult(500);
            }
        }

        //categories
        [AllowAnonymous]
        [HttpGet]
        [Route("categories")]
        public async Task<ActionResult<List<Category>>> GetCategory()
        {
            try{
                return new OkObjectResult(await _CategoryService.GetCategory());
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}

