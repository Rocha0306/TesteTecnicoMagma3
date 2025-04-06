using BackEnd.DTOs;
using BackEnd.Entities;
using BackEnd.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{

    [Route("Clientes")]
    public class ControllerClients : Controller
    {
        private readonly IServiceClientes serviceClientes; 
        public ControllerClients(IServiceClientes services)
        {
            serviceClientes = services;
        }

        [HttpGet]
        public ActionResult<List<ClientesEntity>> ListaClientes()
        {
            return Ok(serviceClientes.GetClientes());  
        }

        
        [HttpPost] 
        public ActionResult<ClientesEntity> PostClientes([FromBody] DTOs.ClientesDTO clientsDTO) {
            return serviceClientes.AddClientes(clientsDTO); 
 
        }


    }
}
