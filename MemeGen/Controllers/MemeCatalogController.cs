using System.Collections.Generic;
using System.Threading.Tasks;
using MemeGen.Application.Models;
using MemeGen.Application.Services;
using MemeGen.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MemeGen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemeCatalogController : ControllerBase
    {
        private readonly IMemeService _memeService;

        public MemeCatalogController(IMemeService memeService)
        {
            _memeService = memeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MemeCatalogDto>>> GetMemeCatalog()
        {
            return Ok(await _memeService.GetMemeCatalog());
        }
    }
}
