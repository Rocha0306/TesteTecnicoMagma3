using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace BackEnd.Interfaces
{
    public interface ITokenService
    {
        public string GeneratorToken();

        public bool ValidatorToken(string UserToken);
    }
}
