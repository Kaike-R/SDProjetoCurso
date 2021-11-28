using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemasDistribuidos.Models;

namespace SistemasDistribuidos.Controllers
{
    
    [ApiController]
    [Route("Secador")]
    public class DecantadorController : ControllerBase
    {
        Decantador tanque = Decantador.getInstance();
        ReatorETOH reatorEtoh = ReatorETOH.getInstance();
        TanqueGlicerina tanqueGlicerina = TanqueGlicerina.getInstance();
        Random rnd = new Random();

        [HttpPost]
        [Route("SetDecantador")]
        public async Task<ActionResult<dynamic>> EntradaSecador([FromBody] Entrada usr)
        {   
            //await Task.Delay(10000);
            if (tanque.Volume + usr.x >= 10)
            {
                return Ok(42);
            }
            double tempo = usr.x;
            tanque.Volume = tanque.Volume + tempo;
            return Ok(tanque.Volume);
            
        }

        [HttpGet]
        [Route("SeeDecantador")]
        public async Task<ActionResult<dynamic>> Ver()
        {
            return Ok(tanque.Volume);
        }

        [HttpGet]
        [Route("GetDecantador")]
        public async Task<ActionResult<dynamic>> SaidaDecantador()
        {
            if (tanque.Volume == 0)
            {
                return Ok(0);
            }
            else
            {
                double gli = tanque.Volume * 3/100;
                tanqueGlicerina.Volume = gli + tanqueGlicerina.Volume;

                double etoh = tanque.Volume * 9/100;
                double perda = etoh * 2.5/100;
                etoh = etoh -perda;
                reatorEtoh.Volume = reatorEtoh.Volume + etoh; 

                double solucao = tanque.Volume * 88/100;
                return Ok(solucao);
            }
            
           
        }


    }
}