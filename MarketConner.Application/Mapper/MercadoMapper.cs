using AutoMapper;
using MarketConner.Application.EntradaCadastrarMercado.cs;
using MarketConner.Domain.Entities;

namespace MarketConner.Application.Mapper
{
    internal class MercadoMapper:Profile
    {

        public MercadoMapper()
        {
            CreateMap<EntradaCadastrarMercadoDto, Mercado>();
        }  
        
    }
}
