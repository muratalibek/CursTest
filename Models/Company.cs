﻿using MongoDB.Bson;
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
        public string Id { get; set; }
        public string Name { get; set; }
        public int BIN { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string Adress { get; set; }   
        public string PhoneNumber { get; set; }
        //public ImageSource Image { get; set; }
        public int KRP { get; set; }
        public List<Object> CompanyActivity { get; set; }
        public string Description { get; set; }
        public int Staff { get; set; }
    }
}
