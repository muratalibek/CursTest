using CursTest.Models;
using System.Collections.Generic;

namespace CursTest.Services.CompanyService
{
    public interface IImageDataService
    {
        List<Image> GetImages();
        Image GetImage(string id);
        Image AddImage(Image image);
        void DeleteImage(string id);
    }
}
