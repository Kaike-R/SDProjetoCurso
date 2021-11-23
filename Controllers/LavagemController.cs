using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemasDistribuidos.Models;

namespace SistemasDistribuidos.Controllers
{
    
    [ApiController]
    [Route("Lavagem")]
    public class LavagemController : ControllerBase
    {
        Lavagem lavagem = Lavagem.getInstance();

        Lavagem2 lavagem2 = Lavagem2.getInstance();

        Lavagem3 lavagem3 = Lavagem3.getInstance();

        Random rnd = new Random();

        [HttpPost]
        [Route("SetLavagem")]
        public async Task<ActionResult<dynamic>> EntradaDecantador([FromBody] Entrada2 usr)
        {   
            //await Task.Delay(10000);
            

            double perda = usr.x * 9.5/100;
            double tempo = usr.x - perda;
            lavagem.Volume = lavagem.Volume + tempo;
            return Ok(lavagem.Volume);
        }

        [HttpGet]
        [Route("SeeLavagem")]
        public async Task<ActionResult<dynamic>> Ver()
        {
            return Ok(lavagem.Volume);
        }

        [HttpGet]
        [Route("GetLavagem")]
        public async Task<ActionResult<dynamic>> SaidaDecantador()
        {
            
            //await Task.Delay(1000);
            if (lavagem.Volume > 1.5)
            {
                lavagem.Volume = lavagem.Volume - 1.5;
                return Ok(1.5);
            }
            if (lavagem.Volume == 1.5)
            {
                lavagem.Volume = lavagem.Volume - 1.5;
                return Ok(1.5);
            }
            else
            {
                var temp = lavagem.Volume;
                lavagem.Volume = 0;
                return Ok(temp);
            }
           
        }

        //Lavagem2
        
        [HttpPost]
        [Route("SetLavagem2")]
        public async Task<ActionResult<dynamic>> EntradaLavagem2([FromBody] Entrada2 usr)
        {   
            //await Task.Delay(10000);
            

            double perda = usr.x * 9.5/100;
            double tempo = usr.x - perda;
            lavagem2.Volume = lavagem2.Volume + tempo;
            return Ok(lavagem2.Volume);
        }

        [HttpGet]
        [Route("SeeLavagem2")]
        public async Task<ActionResult<dynamic>> Ver2()
        {
            return Ok(lavagem2.Volume);
        }

        [HttpGet]
        [Route("GetLavagem2")]
        public async Task<ActionResult<dynamic>> SaidaLavagem2()
        {
            
            //await Task.Delay(1000);
            if (lavagem.Volume > 1.5)
            {
                lavagem2.Volume = lavagem2.Volume - 1.5;
                return Ok(1.5);
            }
            if (lavagem.Volume == 1.5)
            {
                lavagem2.Volume = lavagem2.Volume - 1.5;
                return Ok(1.5);
            }
            else
            {
                var temp = lavagem2.Volume;
                lavagem2.Volume = 0;
                return Ok(temp);
            }
           
        }

        //lavagem 3

        [HttpPost]
        [Route("SetLavagem")]
        public async Task<ActionResult<dynamic>> EntradaLavagem3([FromBody] Entrada3 usr)
        {   
            //await Task.Delay(10000);
            

            double perda = usr.x * 9.5/100;
            double tempo = usr.x - perda;
            lavagem3.Volume = lavagem3.Volume + tempo;
            return Ok(lavagem3.Volume);
        }

        [HttpGet]
        [Route("SeeLavagem")]
        public async Task<ActionResult<dynamic>> Ver3()
        {
            return Ok(lavagem3.Volume);
        }

        [HttpGet]
        [Route("GetLavagem3")]
        public async Task<ActionResult<dynamic>> SaidaLavagem3()
        {
            
            //await Task.Delay(1000);
            if (lavagem3.Volume > 1.5)
            {
                lavagem3.Volume = lavagem3.Volume - 1.5;
                return Ok(1.5);
            }
            if (lavagem3.Volume == 1.5)
            {
                lavagem3.Volume = lavagem3.Volume - 1.5;
                return Ok(1.5);
            }
            else
            {
                var temp = lavagem3.Volume;
                lavagem3.Volume = 0;
                return Ok(temp);
            }
           
        }



    }
}