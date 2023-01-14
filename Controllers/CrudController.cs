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
{   /// <summary>
    /// CRUD Controller для получения/добавления/изменения/удаления организаций базе данных CompanyregisterDb
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CrudController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        /// <summary>
        /// Конструктор для инициализации объектов
        /// </summary>
        public CrudController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        /// <summary>
        /// Get метод для получения общего списка с коллекции Companies в базе данных CompanyregisterDb
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCompanies()
        {
            return Ok(_companyService.GetCompanies());
        }
        /// <summary>
        /// Get метод для получения одного объекта по идентификатору с коллекции Companies в базе данных CompanyregisterDb
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetCompany")]
        public IActionResult GetCompany(string id) 
        {
            return Ok(_companyService.GetCompany(id));
        }
        /// <summary>
        /// Post метод для добавления объекта(компания) в коллекцию Companies в базе данных CompanyregisterDb
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddCompany(Company company)
        {
            company.Id = ObjectId.GenerateNewId().ToString();
            _companyService.AddCompany(company);
            return CreatedAtRoute("GetCompany", new {id = company.Id}, company);    
        }
        /// <summary>
        /// Delete метод для удаления объекта по идентификатору с коллекции Companies в базе данных CompanyregisterDb
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteCompany(string id)
        {
            _companyService.DeleteCompany(id);
            return NoContent();
        }
        /// <summary>
        /// Put метод для обновления объекта по идентификатору с коллекции Companies в базе данных CompanyregisterDb
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult PutCompany(Company company)
        {
            return Ok(_companyService.UpdateCompany(company));
        }

    }
}
