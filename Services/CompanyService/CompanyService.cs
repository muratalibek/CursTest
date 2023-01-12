using CursTest.Models;
using System.Collections.Generic;

namespace CursTest.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        public List<Company> GetCompanies()//This method going to return companies 
        {
            return new List<Company> { new Company() };
        }
    }
}
