using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BackEnd.DTOs
{
    public class ClientesDTO
    {
        [Required(ErrorMessage = "Id necessario")]
        
        public string Id {get; set; }   

        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression("^\\d{10,11}$\r\n")]
        public string Celular { get; set; }

        public string Empresa { get; set; }




    }
}
