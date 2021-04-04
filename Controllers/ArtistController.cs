using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kunstgalerij.Models;
using kunstgalerij.Services;
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
        private readonly ILogger<ArtistController> _logger;

        public ArtistController(ILogger<ArtistController> logger,IArtistService ArtistService, IArtworkService ArtworkService)
        {
            _logger = logger;
            _ArtistService = ArtistService;
            _ArtworkService = ArtworkService;
        }

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

        [HttpGet]
        [Route("artworks")]
        public async Task<ActionResult<List<Artist>>> GetArtwork()
        {
            try{
                return new OkObjectResult(await _ArtworkService.GetArtwork());
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
        
    }
}
