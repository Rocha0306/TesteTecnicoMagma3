using BackEnd.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BackEnd.Infrastructure
{
    public class TokenService : ITokenService   
    {

        private SecurityToken securityToken;

        public JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

        private readonly IConfiguration appSettings;

        public TokenService(IConfiguration configuration)
        {
            appSettings = configuration; 
        }


        public string GeneratorToken()

        {

            string TokenKey = appSettings.GetValue<string>("TokenKey"); 
            string Issuer = "Auth"; //Conteudo do Token - Issuer
            string Audience = "Client"; //Quem consome o token
            //DateTime Expires = DateTime.Now.AddMinutes(10); //Date Time - Expiration - Expiração do Token
            //DateTime NotBefore = DateTime.Now.AddMilliseconds(1); //NotBefore - Tempo que o token não é considerado 
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenKey));
            SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            securityToken = jwtSecurityTokenHandler.CreateJwtSecurityToken(Issuer, Audience, null, null, null, null, signingCredentials);
            return jwtSecurityTokenHandler.WriteToken(securityToken);

        }

        public bool ValidatorToken(string UserToken)
        {
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("571e5851c09f813ec390b91790c0f276ebafacdf789012914a006992f29278c1"));
            TokenValidationParameters tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = "Auth",
                ValidateAudience = true,
                ValidAudience = "Client",
                IssuerSigningKey = key
            };
            Task<TokenValidationResult> tokenValidationResult = jwtSecurityTokenHandler.ValidateTokenAsync(UserToken, tokenValidationParameters);
            bool Result = tokenValidationResult.Result.IsValid;
            return Result;
        }
    }
}
