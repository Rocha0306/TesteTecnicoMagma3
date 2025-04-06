using Entities;
using MongoDB.Driver;

namespace Repository
{
    public class UsersRepository
    {

        private MongoClient mongoClient; 

        private IMongoDatabase database; 

        public UsersRepository()
        {
            var ConnectionString = File.ReadAllText("MongoConfig.json"); 
            mongoClient = new MongoClient(ConnectionString);
            database = mongoClient.GetDatabase("Magma3TesteTecnico"); 

    }

        public void AdicionarCliente(Users users)
        {
            var x = database.GetCollection<Users>("Users");
        }
}
