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
    [Route("Secador")]
    public class SecadorController : ControllerBase
    {
        Secador tanque = Secador.getInstance();
        TanqueDeBiodisel bio = TanqueDeBiodisel.getInstance();
        Random rnd = new Random();

        [HttpPost]
        [Route("SetSecador")]
        public async Task<ActionResult<dynamic>> EntradaDeOlheo([FromBody] Entrada4 usr)
        {

            
            //await Task.Delay(10000);
            double perde = tanque.Volume * 2.5 / 100 ;
            double tempo = usr.x - perde;
            tanque.Volume = tanque.Volume + tempo;
            return Ok(tanque.Volume);
        }

        

        [HttpGet]
        [Route("GetSecador")]
        public async Task<ActionResult<dynamic>> SaidaDeOleo()
        {

            //await Task.Delay(1000);
            if (tanque.Volume > 0.2)
            {
                tanque.Volume = tanque.Volume - 0.2;
                bio.Volume = bio.Volume + 0.2;
                return Ok(0.2);
            }
            if (tanque.Volume == 0.2)
            {
                tanque.Volume = tanque.Volume - 0.2;
                bio.Volume = bio.Volume + 0.2;
                return Ok(0.2);
            }
            else
            {
                var temp = tanque.Volume;
                tanque.Volume = 0;
                bio.Volume = bio.Volume + temp;
                return Ok(temp);
            }
            
        }
    }
}