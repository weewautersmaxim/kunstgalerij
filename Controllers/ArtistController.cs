using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using kunstgalerij.DTO;
using kunstgalerij.Models;
using kunstgalerij.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace kunstgalerij.Controllers
{
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

        //artists
        [HttpGet]
        [Route("artists")]
        public async Task<ActionResult<List<Artist>>> GetArtist()
        {
            try{
                return new OkObjectResult(await _ArtistService.GetArtist());
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
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
        [HttpGet]
        [Route("artworks")]
        public async Task<ActionResult<List<ArtworkDTO>>> GetArtwork()
        {
            try{
                return new OkObjectResult(await _ArtworkService.GetArtwork());
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }

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

