using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemasDistribuidos.Models;

namespace SistemasDistribuidos.Controllers
{
    [ApiController]
    [Route("TanqueDeGli")]
    public class TanqueDeGlicerinaController : ControllerBase
    {
        TanqueGlicerina tanque = TanqueGlicerina.getInstance();

        [HttpGet]
        [Route("SeeGli")]
        public async Task<ActionResult<dynamic>> VerGli(){
            return Ok(tanque.Volume);
        }
    }
}