using CursTest.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CursTest.Data
{
    public interface IDbClient
    {
        IMongoCollection<Company> GetCompaniesCollection();
    }
}
