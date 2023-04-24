namespace ProjMongoDB20230424.Config
{
    public interface IProjMongoDbSettings
    {
        string ClientCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
