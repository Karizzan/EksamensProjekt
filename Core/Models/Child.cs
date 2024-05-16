﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Child
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        //public int ChildID { get; set; }
        public string ChildName { get; set; }
        public int ChildAge { get; set; }
        public string TshirtSize { get; set; }
        public string Comment { get; set; } 
        public string Allergies { get; set; }
        public bool BeenHereBefore { get; set; }
        public string Interests { get; set; } 

    }
}
