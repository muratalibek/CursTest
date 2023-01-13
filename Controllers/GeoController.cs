using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Security.Policy;

namespace CursTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoController : ControllerBase
    {
        
        [HttpGet("{geocode}", Name = "GetGeocode")]
        public IActionResult GetCompany(string geocode)
        {
            var URL = "https://geocode-maps.yandex.ru/1.x/";
            var apiKey = "aa336764-02e7-4e79-ad26-7e5dba2d76e7";
            //37.611347,55.760241
            var client = new RestClient(URL + $"?apikey={apiKey}&geocode={geocode}&format=json&results=5");
            var response = client.Execute(new RestRequest());
            
            return Ok(response.Content);
        }       
    }
}
