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
        TanqueDeOleo tanque = TanqueDeOleo.getInstance();
        Random rnd = new Random();

        [HttpPost]
        [Route("SetBiodisel")]
        public async Task<ActionResult<dynamic>> EntradaBiodisel([FromBody] Entrada5 usr)
        {

            
            //await Task.Delay(10000);
            double tempo = usr.x;
            tanque.Volume = tanque.Volume + tempo;
            return Ok(tanque.Volume);
        }

        [HttpGet]
        [Route("SeeBiodisel")]
        public async Task<ActionResult<dynamic>> VerBiodisel(){
            return Ok(tanque.Volume);
        }


        
    }
}  