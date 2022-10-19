namespace ExemploWebApiMongo.Utils.Interface
{
    public interface IDatabaseSettings
    {
        string ClientCollectionName { get; set; }
        string AddressCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }

    }
}
