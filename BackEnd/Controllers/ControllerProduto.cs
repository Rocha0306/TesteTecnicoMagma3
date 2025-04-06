using BackEnd.DTOs;
using BackEnd.Entities;
using BackEnd.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{

    [Route("Produto")]
    public class ControllerProduto : Controller
    {
        private readonly IServiceProduto serviceProduto;
        public ControllerProduto(IServiceProduto _serviceProduto)
        {
            serviceProduto = _serviceProduto;   
        }

        [HttpPost] 
        public ActionResult<ProdutoDTO> PostProduto([FromBody] ProdutoDTO produtoDTO)
        {
            serviceProduto.AdicionarProdutos(produtoDTO);
            return Ok(produtoDTO);
        }

        [HttpGet]
        public ActionResult<List<ProdutoEntity>> GetProdutos()
        {
            return Ok(serviceProduto.ListarProdutos());
           
        }
    }
}
