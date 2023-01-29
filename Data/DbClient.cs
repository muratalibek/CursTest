using CursTest.Models;
using CursTest.Services.CompanyService;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CursTest.Data
{   /// <summary>
    /// Класс для соединения с БД и его коллекциями. Так как СУБД не реляционная соединения настраивал с каждой коллекцией.
    /// </summary>
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Company> _companies;
        private readonly IMongoCollection<KRP> _krp;
        private readonly IMongoCollection<Image> _image;
        
        public DbClient(IOptions<DataContext> dataContext)
        {
            var client = new MongoClient(dataContext.Value.Connection_String);

            var database = client.GetDatabase(dataContext.Value.Database_Name);
            _companies = database.GetCollection<Company>(dataContext.Value.Companies_Collection_Name);
            _krp = database.GetCollection<KRP>(dataContext.Value.Jsonfilename_Collection_Name);
            _image = database.GetCollection<Image>(dataContext.Value.Image_Collection_Name);
        }
        public IMongoCollection<Company> GetCompaniesCollection() => _companies;
        public IMongoCollection<KRP> GetKRPCollection() => _krp;
        public IMongoCollection<Image> GetImageCollection() => _image;
    }
}
