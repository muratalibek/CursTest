using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CursTest.Models
{
    /// <summary>
    /// КРП - Классификатор размерности предприятий
    /// </summary>
    public class Company
    {
        [BsonId] // Service Id to define primary key for Mongo Db
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [Required]// to make non-nulable string property
        public string Id { get; set; } //Идентификатор
        public string Name { get; set; } //наименование (строка)
        public int BIN { get; set; } //БИН 
        public DateTime EstablishmentDate { get; set; }//дата основания (дата)
        public string Adress { get; set; }//адрес
        public string PhoneNumber { get; set; }//телефон
        //public ImageSource Image { get; set; }
        public int KRP { get; set; } //КРП
        public List<Object> CompanyActivity { get; set; }//деятельность (многозначное поле)
        public string Description { get; set; }//описание (строка)
        public int Staff { get; set; }//количество сотрудников (целые числа) 
    }
}
