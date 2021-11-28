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
    [Route("ReatorNaoh")]
    public class ReatorNAOHController:ControllerBase
    {
        ReatorNAOH tanque = ReatorNAOH.getInstance();

        Random rnd = new Random();

        [HttpPost]
        [Route("SetNaoh")]
        public async Task<ActionResult<dynamic>> EntradaDeNaoh()
        {

            //await Task.Delay(250);
            double tempo = 0.25;
            tanque.Volume = tanque.Volume + tempo;
            return Ok(tanque.Volume);
        }

        [HttpGet]
        [Route("SeeNaoh")]
        public async Task<ActionResult<dynamic>> verNaoh()
        {
            return Ok(tanque.Volume);
        }

        [HttpGet]
        [Route("GetNaoh")]
        public async Task<ActionResult<dynamic>> SaidaDeNaoh()
        {
            //limitando a saida para cobrir a proporção
            //await Task.Delay(1000);
            if (tanque.Volume > 0.041)
            {
                tanque.Volume = tanque.Volume - 0.041;
                return Ok(0.041);
            }
            if (tanque.Volume == 0.041)
            {
                tanque.Volume = tanque.Volume - 0.041;
                return Ok(0.041);
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