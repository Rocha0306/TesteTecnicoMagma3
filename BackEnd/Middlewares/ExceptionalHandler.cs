using BackEnd.DTOs;
using MongoDB.Driver;

namespace BackEnd.Middlewares
{
    public class ExceptionalHandler : Exception
    {
        private readonly RequestDelegate next;

        public ExceptionDTO exceptionDTO = new ExceptionDTO();

        public ExceptionalHandler(RequestDelegate requestDelegate)
        {
            next = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            var response = context.Response; 

            try
            {
                await next(context);
            }

            catch (NotImplementedException ex)
            {
                exceptionDTO.Message = "Recusado, se não tá no banco";
                exceptionDTO.StatusErrorCode = 403;
                response.ContentType = "application/json";
                response.StatusCode = exceptionDTO.StatusErrorCode;
                await response.WriteAsJsonAsync(exceptionDTO);
            }

            catch (BadHttpRequestException ex)
            {
                exceptionDTO.Message = ex.Message; 
                exceptionDTO.StatusErrorCode = 400;
                response.ContentType = "application/json";
                response.StatusCode = exceptionDTO.StatusErrorCode;
                await response.WriteAsJsonAsync(exceptionDTO);
            }

            catch (MongoWriteException ex)
            {
                exceptionDTO.Message = "já ta no banco esse registro que se tá tentando inserir";
                exceptionDTO.StatusErrorCode = 400;
                response.ContentType = "application/json";
                response.StatusCode = exceptionDTO.StatusErrorCode;
                await response.WriteAsJsonAsync(exceptionDTO);
            }




        }
    }
}
