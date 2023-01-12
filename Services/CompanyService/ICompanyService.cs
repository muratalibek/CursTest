using CursTest.Models;
using System.Collections.Generic;

namespace CursTest.Services.CompanyService
{
    public interface ICompanyService
    {
        List<Company> GetCompanies();
    }
}
