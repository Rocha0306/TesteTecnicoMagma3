using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BackEnd.Entities
{
    public class ClientesEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public string Empresa { get; set; } 


    }
}
