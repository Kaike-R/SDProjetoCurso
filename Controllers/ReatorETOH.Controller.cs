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
    [Route("ReatorEtoh")]
    public class ReatorETOHController:ControllerBase
    {
        ReatorETOH tanque = ReatorETOH.getInstance();

        Random rnd = new Random();

        [HttpPost]
        [Route("SetEtoh")]
        public async Task<ActionResult<dynamic>> EntradaDeNaoh()
        {

            //await Task.Delay(250);
            double tempo = 0.125;
            tanque.Volume = tanque.Volume + tempo;
            return Ok(tanque.Volume);
        }

        [HttpGet]
        [Route("SeeEtoh")]
        public async Task<ActionResult<dynamic>> verNaoh()
        {
            return Ok(tanque.Volume);
        }

        [HttpGet]
        [Route("GetEtoh")]
        public async Task<ActionResult<dynamic>> SaidaDeNaoh()
        {

            //await Task.Delay(1000);
            if (tanque.Volume > 1)
            {
                tanque.Volume = tanque.Volume - 1;
                return Ok(1);
            }
            if (tanque.Volume == 1)
            {
                tanque.Volume = tanque.Volume - 1;
                return Ok(1);
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