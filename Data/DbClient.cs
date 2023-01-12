using CursTest.Models;
using CursTest.Services.CompanyService;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CursTest.Data
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Company> _companies;
        public DbClient(IOptions<DataContext> dataContext) 
        {
            var client = new MongoClient(dataContext.Value.Connection_String);
            var dataBase = client.GetDatabase(dataContext.Value.Database_Name);
            _companies = dataBase.GetCollection<Company>(dataContext.Value.Company_Collection_name);
        }
            public IMongoCollection<Company> GetCompaniesCollection() => _companies;
    }
}
