using AutoMapper;
using BackEnd.DTOs;
using BackEnd.Entities;

namespace BackEnd.Interfaces
{
    public interface IServiceProduto
    {
        public ProdutoEntity AdicionarProdutos(ProdutoDTO produtoDTO);

        public List<ProdutoEntity> ListarProdutos();
    }
}
