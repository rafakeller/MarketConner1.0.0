using AutoMapper;
using MarketConner.Application.EntradaCadastrarMercado.cs;
using MarketConner.Domain.Entities;
using MarketConner.Infra.Banco;
using Microsoft.AspNetCore.Mvc;

namespace MarketConner.Controllers
{
    [Route("api/mercado")]
    [ApiController]
    public class MercadoController:ControllerBase
    {
        private readonly MarketConnerContext contextMercado;
 

        public MercadoController(MarketConnerContext context)
        {
            this.contextMercado=context;
         
        }

        [HttpPost("adicionarMercado")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void AdicionandoMercados([FromBody] Mercado mercado)
        {
           contextMercado.Mercados.Add(mercado);
           contextMercado.SaveChanges();

        }

        //[HttpGet("consultarMercado")]
        //public IEnumerable<Mercado> ConsultandoMercados()
        //{
        //  return  contextMercado.Mercados.ToList();
           

        //}
    }
}
