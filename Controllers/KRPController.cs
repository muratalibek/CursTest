using CursTest.Services.CompanyService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CursTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KRPController : ControllerBase
    {
        private readonly IKRPService _krpService;
        public KRPController(IKRPService krpService)
        {
            _krpService = krpService;
        }

        [HttpGet]
        public IActionResult GetKRPs()// Controller action
        {
            return Ok(_krpService.GetKRPs());// Service method
        }

        [HttpGet("{id}", Name = "Krp")]
        public IActionResult GetKRP(string id)
        {
            return Ok(_krpService.GetKRP(id));
        }
    }
}
