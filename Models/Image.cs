using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CursTest.Models
{
    public class Image
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public string Descripton { get; set; }
        public string base64String { get; set; }
    }
}
