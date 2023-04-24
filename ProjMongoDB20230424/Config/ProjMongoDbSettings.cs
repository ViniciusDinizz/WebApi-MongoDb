namespace ProjMongoDB20230424.Config
{
    public class ProjMongoDbSettings : IProjMongoDbSettings
    {
        public string ClientCollectionName { get ; set ; }
        public string ConnectionString { get ; set ; }
        public string DatabaseName { get ; set ; }
    }
}
