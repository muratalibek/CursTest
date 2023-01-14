using CursTest.Services.CompanyService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CursTest.Controllers
{
    /// <summary>
    /// КРП контроллер для получения характеристик организаций по идентификатору c файла JsonKRP. Список был внедрен в базу данных CompanyregisterDb.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class KRPController : ControllerBase
    {
        private readonly IKRPService _krpService;
        public KRPController(IKRPService krpService)
        {
            _krpService = krpService;
        }
        /// <summary>
        /// Get метод для получения общего списка с характеристиками организаций
        /// </summary>
        [HttpGet]
        public IActionResult GetKRPs()
        {
            return Ok(_krpService.GetKRPs());
        }
        /// <summary>
        /// Get метод для получения определенной характеристики организации через индентификатор
        /// </summary>
        [HttpGet("{id}", Name = "Krp")]
        public IActionResult GetKRP(string id)
        {
            return Ok(_krpService.GetKRP(id));
        }
    }
}
