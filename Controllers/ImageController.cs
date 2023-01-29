using CursTest.Models;
using CursTest.Services.CompanyService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace CursTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageDataService _imageDataService;
        public ImageController(IImageDataService imageDataService)
        {
            _imageDataService= imageDataService;
        }
        [HttpPost]
        public IActionResult UploadImage(Image image)
        {
            image.Id = ObjectId.GenerateNewId().ToString();
            _imageDataService.AddImage(image);
            return Ok(new { id = image.Id });
        }
        [HttpGet]
        public IActionResult GetImages()
        {
            return Ok(_imageDataService.GetImages());
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteImage(string id)
        {
            _imageDataService.DeleteImage(id);
            return NoContent();
        }
    }
}
