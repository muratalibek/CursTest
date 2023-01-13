using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Security.Policy;

namespace CursTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GeoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet("{geocode}", Name = "GetGeocode")]
        public IActionResult GetCompany(string geocode)
        {
            var URL = _configuration.GetValue<string>("YandexURL");
            var apiKey = _configuration.GetValue<string>("YandexAPIKey");
            //37.611347,55.760241
            var client = new RestClient(URL + $"?apikey={apiKey}&geocode={geocode}&format=json&results=5");
            var response = client.Execute(new RestRequest());

            return Ok(response.Content);
        }       
    }
}
