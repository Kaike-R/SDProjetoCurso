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
    [Route("TanqueDeBiodisel")]
    public class TanqueDeBiodiselController : ControllerBase
    {
        TanqueDeBiodisel tanque = TanqueDeBiodisel.getInstance();
        Random rnd = new Random();

        

        [HttpGet]
        [Route("SeeBiodisel")]
        public async Task<ActionResult<dynamic>> VerBiodisel(){
            return Ok(tanque.Volume);
        }



    }
}  