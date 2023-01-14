using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CursTest.Models
{
    public class KRP
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [Required]
        public string _id { get; set; }
        public string id { get; set; }
        public string Name { get; set; }
    }
}
