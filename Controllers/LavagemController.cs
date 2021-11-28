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

        // Lavagem2 lavagem2 = Lavagem2.getInstance();

        // Lavagem3 lavagem3 = Lavagem3.getInstance();

        Random rnd = new Random();

        [HttpPost]
        [Route("SetLavagem")]
        public async Task<ActionResult<dynamic>> EntradaDecantador([FromBody] Entrada2 usr)
        {   
            //await Task.Delay(10000);
            

            double perda = usr.x * 0.095;
            double tempo = usr.x - perda;
            double perda2 = tempo * 0.095;
            double tempo2 = tempo - perda2;
            double perda3 = tempo2 * 0.095;
            double tempo3 = tempo2 - perda3;
            if (tempo < 0 || tempo2 < 0 || tempo3 < 0)
            {
                Console.WriteLine("EstaNegativo");
            }
            lavagem.Volume = lavagem.Volume + tempo3;
            return Ok(lavagem.Volume);
            //return Ok(1);
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

        // //Lavagem2
        
        // [HttpPost]
        // [Route("SetLavagem2")]
        // public async Task<ActionResult<dynamic>> EntradaLavagem2([FromBody] Entrada2 usr)
        // {   
        //     //await Task.Delay(10000);
            

        //     double perda = usr.x * 0.095;
        //     double tempo = usr.x - perda;
        //     lavagem2.Volume = lavagem2.Volume + tempo;
        //     return Ok(lavagem2.Volume);
        // }

        // [HttpGet]
        // [Route("SeeLavagem2")]
        // public async Task<ActionResult<dynamic>> Ver2()
        // {
        //     return Ok(lavagem2.Volume);
        // }

        // [HttpGet]
        // [Route("GetLavagem2")]
        // public async Task<ActionResult<dynamic>> SaidaLavagem2()
        // {
            
        //     //await Task.Delay(1000);
        //     if (lavagem.Volume > 1.5)
        //     {
        //         lavagem2.Volume = lavagem2.Volume - 1.5;
        //         return Ok(1.5);
        //     }
        //     if (lavagem.Volume == 1.5)
        //     {
        //         lavagem2.Volume = lavagem2.Volume - 1.5;
        //         return Ok(1.5);
        //     }
        //     else
        //     {
        //         var temp = lavagem2.Volume;
        //         lavagem2.Volume = 0;
        //         return Ok(temp);
        //     }
           
        // }

        // //lavagem 3

        // [HttpPost]
        // [Route("SetLavagem3")]
        // public async Task<ActionResult<dynamic>> EntradaLavagem3([FromBody] Entrada3 usr)
        // {   
        //     //await Task.Delay(10000);
            

        //     double perda = usr.x * 0.095;
        //     double tempo = usr.x - perda;
        //     lavagem3.Volume = lavagem3.Volume + tempo;
        //     return Ok(lavagem3.Volume);
        // }

        // [HttpGet]
        // [Route("SeeLavagem3")]
        // public async Task<ActionResult<dynamic>> Ver3()
        // {
        //     return Ok(lavagem3.Volume);
        // }

        // [HttpGet]
        // [Route("GetLavagem3")]
        // public async Task<ActionResult<dynamic>> SaidaLavagem3()
        // {
            
        //     //await Task.Delay(1000);
        //     if (lavagem3.Volume > 1.5)
        //     {
        //         lavagem3.Volume = lavagem3.Volume - 1.5;
        //         return Ok(1.5);
        //     }
        //     if (lavagem3.Volume == 1.5)
        //     {
        //         lavagem3.Volume = lavagem3.Volume - 1.5;
        //         return Ok(1.5);
        //     }
        //     else
        //     {
        //         var temp = lavagem3.Volume;
        //         lavagem3.Volume = 0;
        //         return Ok(temp);
        //     }
           
        //}



    }
}