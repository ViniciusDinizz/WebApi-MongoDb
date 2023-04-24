using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjMongoDB20230424.Models
{
    public class Client
    {
        //Primeiro criar a entidade
        //Propriedades definida com Data Notattion em Id
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
