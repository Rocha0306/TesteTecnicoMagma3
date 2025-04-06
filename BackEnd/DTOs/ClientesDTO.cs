using System.ComponentModel.DataAnnotations;

namespace BackEnd.DTOs
{
    public class ClientesDTO
    {
        public string Id = Guid.NewGuid().ToString();   

        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression("^\\d{10,11}$\r\n")]
        public string Celular { get; set; }

        public string Empresa { get; set; }




    }
}
