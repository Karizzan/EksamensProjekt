﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Parent
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int ParentID { get; set; }
        public string ParentName { get; set; }
        public int KræwNumber { get; set; }
        public string ParentMail { get; set; }
        public List<Child> Children { get; set; } = new List<Child>();
    }
}
