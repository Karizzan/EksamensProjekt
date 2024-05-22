﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Application
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int ApplicationID { get; set; }
        public DateTime SubmitDate { get; set; }
        public Event Priority1 { get; set; } = new Event();
        public Event Priority2 { get; set; } = new Event();
        public Parent Parent { get; set; } = new Parent();
        public bool IsOnWaitingList { get; set; } = true;
        public bool Verified { get; set; } = false;
        public string Signature { get; set; } // Underskrift
        public byte[] SignatureImage { get; set; }

    }
}
