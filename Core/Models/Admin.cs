using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Models
{
    public class Admin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int AdminID { get; set; }

        public string AdminLevel { get; set; } = "Admin";
		public string AdminName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
