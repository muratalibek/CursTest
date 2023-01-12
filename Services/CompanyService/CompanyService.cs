using CursTest.Data;
using CursTest.Models;
using Microsoft.AspNetCore.Mvc;
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
            return _companies.Find(x => true).ToList();
            //return _companies.Find(new Company()).ToList();
        }
        public Company GetCompany(string id)
        {
            return _companies.Find(company => company.Id == id).First();
        }
        public Company AddCompany(Company company)
        {
            _companies.InsertOne(company);
            return company;
        }

        public void DeleteCompany(string id)
        {
            _companies.DeleteOne(company => company.Id == id);
        }

        public Company UpdateCompany(Company company)
        {
            GetCompany(company.Id);
            _companies.ReplaceOne(c => c.Id == company.Id, company);
            return company; 
        }
    }
}
