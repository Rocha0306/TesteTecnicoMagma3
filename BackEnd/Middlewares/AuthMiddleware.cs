using BackEnd.DTOs;
using BackEnd.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Extensions;
using System.Security.Cryptography.X509Certificates;

namespace BackEnd.Middlewares
{
    public class AuthMiddleware
    {

        private readonly RequestDelegate _next;

        private readonly ITokenService tokenService;
        public AuthMiddleware(ITokenService _tokenService, RequestDelegate _requestdelegate)
        {
            tokenService = _tokenService; 
            _next = _requestdelegate;   
        }
        public async Task Invoke(HttpContext httpContext)
        {

            var response = httpContext.Response;
            ExceptionDTO exceptionDTO = new ExceptionDTO();

            var endpoint = httpContext.Request.GetDisplayUrl();


            if (endpoint != "http://localhost:7070/Auth")
            {
                string Token = httpContext.Request.Query["Token"];
                bool Result = tokenService.ValidatorToken(Token);

                if (Result == true)
                {
                    await _next(httpContext);
                }

                else
                {
                    exceptionDTO.Message = "Recusado, token invalido";
                    exceptionDTO.StatusErrorCode = 403;
                    response.ContentType = "application/json";
                    response.StatusCode = exceptionDTO.StatusErrorCode;
                    await response.WriteAsJsonAsync(exceptionDTO);
                }
            }

            else
            {
                await _next(httpContext);    
            }
           
        }
    }
}
