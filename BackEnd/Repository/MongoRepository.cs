using BackEnd.DTOs;
using BackEnd.Entities;
using BackEnd.Interfaces;
using MongoDB.Driver;
using BackEnd.Entities;

namespace BackEnd.Repository
{
    public class MongoRepository : IMongoRepository
    {

        private MongoClient mongoClient;

        private IMongoDatabase mongoRepository;

        private readonly IConfiguration configuration; 
        public MongoRepository(IConfiguration _configuration)
        {
            configuration = _configuration; 
            mongoClient = new MongoClient("mongodb+srv://lmp:ndranghtea05*@magma3teste.diykqgt.mongodb.net/");
            mongoRepository = mongoClient.GetDatabase("Magma3TesteTecnico");
        }

      

        public List<ClientesEntity> ObterTodos()
        {
            var repository = mongoRepository.GetCollection<ClientesEntity>("Clientes");
            return repository.Find(Builders<ClientesEntity>.Filter.Empty).ToList();

        }

        public ClientesEntity AdicionarCliente(ClientesEntity clientesEntity)
        {

            var repository = mongoRepository.GetCollection<ClientesEntity>("Clientes");
            repository.InsertOne(clientesEntity);
            return clientesEntity; 

        }


        public UsersEntity? FindUsers(UsersEntity users)
        {
            var repository = mongoRepository.GetCollection<UsersEntity>("Users");
            var usersdatabase = repository.Find(x => x.Username.Equals(users.Username)).FirstOrDefault<UsersEntity>();

            return usersdatabase;

        }



        public ClientesEntity EncontraCliente(ClientesEntity cliente)
        {
            var repository = mongoRepository.GetCollection<ClientesEntity>("Clientes");
            var clientedatabase = repository.Find(x => x.Equals(cliente)).FirstOrDefault<ClientesEntity>();
            return clientedatabase; 
            
        }
 
        public void AdicionarProduto(ProdutoEntity produtoEntity)
        {
            var repository = mongoRepository.GetCollection<ProdutoEntity>("Produto");
            repository.InsertOne(produtoEntity);
        }

        public ProdutoEntity EncontraProduto(ProdutoEntity produto)
        {
            var repository = mongoRepository.GetCollection<ProdutoEntity>("Produto");
            return repository.Find<ProdutoEntity>(x => x.Equals(produto)).FirstOrDefault();  
            
        }

        public List<ProdutoEntity> ListarProdutos()
        {
            var repository = mongoRepository.GetCollection<ProdutoEntity>("Produto");
            return repository.Find(Builders<ProdutoEntity>.Filter.Empty).ToList();
        }


    }
}
