using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketConner.Application.EntradaCadastrarMercado.cs
{
    public class EntradaCadastrarMercadoDto
    {
        [Required(ErrorMessage ="Deve fornecer o nome do mercado")]
        public string Nome { get; set; }
        public  string? LogoMarca { get; set; }
        [Required(ErrorMessage = "Deve fornecer o cnpj da empresa")]
        public  string Cnpj { get; set; }
        [Required(ErrorMessage = "Deve fornecer as categorias de produtos fornecidos")]
        public  string Categoria { get; set; }

    }
}
