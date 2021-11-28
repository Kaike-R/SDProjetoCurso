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
    [Route("Reator")]
    public class ReatorController:ControllerBase
    {
        Reator tanque = Reator.getInstance();

        Random rnd = new Random();

        [HttpPost]
        [Route("SetReator")]
        public async Task<ActionResult<dynamic>> EntradaDeNaoh([FromBody] Mistura model)
        {

            //sawait Task.Delay(250);
            
            double tempoOleo = model.Oleo;
            double tempoEaoh = model.Etoh;
            double tempoNaoh = model.Naoh;
            double tempo = tempoOleo + tempoEaoh + tempoNaoh;
            
            tanque.Oleo = tanque.Oleo + tempoOleo;
            tanque.Eaoh = tanque.Eaoh + tempoEaoh;
            tanque.Naoh = tanque.Naoh + tempoNaoh;
            tanque.Mistura = tanque.Volume + tempo;
            return Ok(tanque.Mistura);
        }

        [HttpGet]
        [Route("GetMistura")]
        public async Task<ActionResult<dynamic>> GetMistura(){
            return Ok(tanque.Mistura);
        }

        [HttpGet]
        [Route("GetEtoh")]
        public async Task<ActionResult<dynamic>> GetEtoh(){
            return Ok(tanque.Eaoh);
        }

        [HttpGet]
        [Route("GetNaoh")]
        public async Task<ActionResult<dynamic>> GetNaoh(){
            return Ok(tanque.Naoh);
        }

        [HttpGet]
        [Route("GetOleo")]
        public async Task<ActionResult<dynamic>> GetOleo(){
            return Ok(tanque.Oleo);
        }

        [HttpPost]
        [Route("ProcessarLiquido")]
        public async Task<ActionResult<dynamic>> ProcessarLiquido()
        {
            
            // await Task.Delay(1000);

            if (tanque.Volume /4 == tanque.Naoh && tanque.Volume/4 == tanque.Oleo && tanque.Volume/2 == tanque.Eaoh)
            {
                if (tanque.Mistura > 5)
                {
                    tanque.Mistura = tanque.Mistura - 5;
                    return Ok(5);
                }
                    if (tanque. Mistura == 5)
                {
                    tanque.Mistura = tanque.Mistura - 5;
                    return Ok(5);
                }   
                    else
                {
                    var temp = tanque.Mistura;
                    tanque.Mistura = 0;
                    return Ok(temp);
 
                }
                  
            }
            else {
                return Ok(0);
            }
        }

        [HttpPost]
        [Route("PostVolume")]
        public async Task<ActionResult<dynamic>> PostVolume(){

            if (tanque.Volume > 6)
            {
                tanque.Volume = tanque.Volume - 6;
                return Ok(6);
            }
            if (tanque.Volume == 6)
            {
                tanque.Volume = tanque.Volume - 6;
                return Ok(6);
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