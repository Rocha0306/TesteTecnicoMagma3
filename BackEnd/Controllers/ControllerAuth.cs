using BackEnd.DTOs;
using BackEnd.Infrastructure;
using BackEnd.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BackEnd.Controllers
{

    [Route("Auth")]
    public class ControllerAuth : Controller
    {

        private readonly IServiceUsers serviceUsers;

        public ControllerAuth(IServiceUsers _serviceUsers)
        {
            serviceUsers = _serviceUsers;   
        }


        [HttpPost]
        public ActionResult<TokenDTO> Registration([FromBody] UsersDTO usersDTO)
        {

            var Token = serviceUsers.Login(usersDTO);
            return Ok(Token);

          
        }

       


    }
}
