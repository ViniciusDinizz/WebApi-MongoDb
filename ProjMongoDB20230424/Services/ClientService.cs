using MongoDB.Driver;
using ProjMongoDB20230424.Config;
using ProjMongoDB20230424.Models;

namespace ProjMongoDB20230424.Services
{
    public class ClientService
    {
        private readonly IMongoCollection<Client> _client;
        //Serviços da entidade
        public ClientService(IProjMongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _client = database.GetCollection<Client>(settings.ClientCollectionName);
        }
        public List<Client> Get() => _client.Find(c => true).ToList();
        public Client Get(string id) => _client.Find(c => c.Id == id).FirstOrDefault();
        public Client Create(Client client)
        {
            _client.InsertOne(client);
            return client;
        }
        public void Update(string id, Client client) => _client.ReplaceOne(c => c.Id == id, client);

        public void Delete (string id) => _client.DeleteOne(c => c.Id == id);

    }
}
