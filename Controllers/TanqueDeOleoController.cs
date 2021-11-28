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
    [Route("TanqueDeOleo")]
    public class TanqueDeOleoController : ControllerBase
    {
        TanqueDeOleo tanque = TanqueDeOleo.getInstance();
        Random rnd = new Random();

        [HttpPost]
        [Route("SetOleo")]
        public async Task<ActionResult<dynamic>> EntradaDeOlheo()
        {

            
            //await Task.Delay(10000);
            double tempo = 1 + 0.1* rnd.Next(10);
            tanque.Volume = tanque.Volume + tempo;
            return Ok(tanque.Volume);
        }

        [HttpGet]
        [Route("SeeOleo")]
        public async Task<ActionResult<dynamic>> VerOleo(){
            return Ok(tanque.Volume);
        }



        [HttpGet]
        [Route("GetOleo")]
        public async Task<ActionResult<dynamic>> SaidaDeOleo()
        {

            //await Task.Delay(1000);
            if (tanque.Volume > 0.5)
            {
                tanque.Volume = tanque.Volume - 0.5;
                return Ok(0.5);
            }
            if (tanque.Volume == 0.5)
            {
                tanque.Volume = tanque.Volume - 0.5;
                return Ok(0.5);
            }
            else
            {
                var temp = tanque.Volume;
                tanque.Volume = 0;
                return Ok(temp);
            }
            
        }
    }
}