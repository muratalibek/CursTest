using CursTest.Models;
using CursTest.Services.CompanyService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Bson.IO;
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
        public IActionResult GetCompanies()
        {
            return Ok(_companyService.GetCompanies());
        }

        [HttpGet("{id}", Name = "GetCompany")]
        public IActionResult GetCompany(string id) 
        {
            return Ok(_companyService.GetCompany(id));
        }

        [HttpPost]
        public IActionResult AddCompany(Company company)
        {
            company.Id = ObjectId.GenerateNewId().ToString();
            _companyService.AddCompany(company);
            return CreatedAtRoute("GetCompany", new {id = company.Id}, company);    
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCompany(string id)
        {
            _companyService.DeleteCompany(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult PutCompany(Company company)
        {
            return Ok(_companyService.UpdateCompany(company));
        }

    }
}
