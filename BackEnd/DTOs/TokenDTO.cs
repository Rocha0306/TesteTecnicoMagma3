namespace BackEnd.DTOs
{
    public class TokenDTO
    {

        public string Token { get; set; }

        public TokenDTO(string _token)
        {
            Token = _token; 
        }

        public TokenDTO()
        {
            
        }


    }
}
