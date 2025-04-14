using System.ComponentModel.DataAnnotations;

namespace BackEnd.DTOs
{
    public class ProdutoDTO
    {
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

    }
}
