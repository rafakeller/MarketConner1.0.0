using System.ComponentModel.DataAnnotations;

namespace MarketConner.Domain.Entities
{
    public class Mercado
    {
        [Key]
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string LogoMarca { get; set; }
        public required string Cnpj { get; set; }
        public required string Categoria { get; set; }


    }
}
