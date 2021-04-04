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
        private readonly ILogger<ArtistController> _logger;

        public ArtistController(ILogger<ArtistController> logger,IArtistService ArtistService)
        {
            _logger = logger;
            _ArtistService = ArtistService;
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
        
    }
}
