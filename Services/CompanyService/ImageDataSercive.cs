using CursTest.Data;
using CursTest.Models;
using Microsoft.VisualBasic;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursTest.Services.CompanyService
{
    public class ImageDataSercive : IImageDataService
    {
        private readonly IMongoCollection<Image> _imageCollection;
        public ImageDataSercive(IDbClient dbClient)
        {
            _imageCollection = dbClient.GetImageCollection();
        }
        public Image AddImage(Image image)
        {
            //if (String.IsNullOrEmpty(image.base64String))
            //    image.Photo = Convert.FromBase64String(image.base64String);
            var imageDb = _imageCollection.Find(x => x.Id == image.Id).FirstOrDefault();
            if (imageDb == null)
            {
                _imageCollection.InsertOne(image);
            }
            else
            {
                _imageCollection.ReplaceOne(x => x.Id == image.Id, image);
            }
            return image;
        }

        public void DeleteImage(string id)
        {
            _imageCollection.DeleteOne(image => image.Id == id);
        }

        public Image GetImage(string id)
        {
            throw new System.NotImplementedException();
        }

        public List<Image> GetImages()
        {
            return _imageCollection.Find(FilterDefinition<Image>.Empty).ToList();
        }
    }
}
