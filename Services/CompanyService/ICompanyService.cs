using CursTest.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CursTest.Services.CompanyService
{
    public interface ICompanyService
    {
        List<Company> GetCompanies();
        Company GetCompany(string id);
        Company AddCompany(Company company);
        void DeleteCompany(string id);
        Company UpdateCompany(Company company);
    }
}
