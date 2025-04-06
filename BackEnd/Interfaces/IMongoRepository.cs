using BackEnd.Entities;
using BackEnd.Repository;
using MongoDB.Driver;

namespace BackEnd.Interfaces
{
    public interface IMongoRepository
    {
        public UsersEntity FindUsers(UsersEntity users);

        public ClientesEntity AdicionarCliente(ClientesEntity users);

        public List<ClientesEntity> ObterTodos();

        public void AdicionarProduto(ProdutoEntity produto);

        public ClientesEntity EncontraCliente(ClientesEntity cliente);

        public ProdutoEntity EncontraProduto(ProdutoEntity produto);

        public List<ProdutoEntity> ListarProdutos(); 
    }
}
