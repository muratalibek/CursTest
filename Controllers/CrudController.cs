using CursTest.Services.CompanyService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrudController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CrudController(ICompanyService companyService)
        {
            _companyService = companyService;
           
        }
        [HttpGet]
        public IActionResult GetCompanies() { return Ok(_companyService.GetCompanies()); }
    }
}
