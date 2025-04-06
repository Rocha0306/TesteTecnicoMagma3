using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace BackEnd.Entities
{
    public class UsersEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }  

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
