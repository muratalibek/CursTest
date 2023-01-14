using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Security.Policy;

namespace CursTest.Controllers
{
    /// <summary>
    /// Контроллер для получения геоданных. Вводенные геолокационные данные выдают адрес 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GeoController : ControllerBase
    {
        /// <summary>
        /// Поле 
        /// </summary>
        private readonly IConfiguration _configuration;
        public GeoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Get Метод через {geocode}, URL и API ключ вводит координаты в сервис IConfiguration и также через response возращает адрес 
        /// </summary>
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
