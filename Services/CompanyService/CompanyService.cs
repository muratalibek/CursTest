using CursTest.Data;
using CursTest.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CursTest.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        private readonly IMongoCollection<Company> _companies;
        public CompanyService(IDbClient dbClient) 
        {
           _companies = dbClient.GetCompaniesCollection();
        }
        public List<Company> GetCompanies()//This method going to return companies 
        {
            return _companies.Find(company => true).ToList();
        }
    }
}
