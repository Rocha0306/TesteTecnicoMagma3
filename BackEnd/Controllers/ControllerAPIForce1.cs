using BackEnd.APIs;
using BackEnd.Interfaces;
using BackEnd.Service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace BackEnd.Controllers
{

    [Route("Force1")]
    public class ControllerAPIForce1 : Controller
    {

        private readonly IServiceFiltro serviceFiltro;

        private readonly IForce1API force1API;  

        public ControllerAPIForce1(IServiceFiltro _serviceFiltro, IForce1API _force1API)
        {
            serviceFiltro = _serviceFiltro;
            force1API = _force1API; 
        }

        [HttpPost]
        public async Task<ActionResult> Index()
        {
            var response = await force1API.PegaAtivos();
            var Maquinas = serviceFiltro.FiltroMaquinas(response);
            return Ok(response.ToJson()); 
        }
    }
}
