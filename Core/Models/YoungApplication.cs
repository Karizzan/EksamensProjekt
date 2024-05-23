using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Models
{
    public class YoungApplication
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public int YoungApplicationID { get; set; }
        public string AName { get; set; }
        public string AMail { get; set; }
        public string AParentName { get; set; }
        public string AParentPhoneNr { get; set; }
        public string AParentMail { get; set; }
        public int KræwNr { get; set; }
        public bool AVerified { get; set; } = false;
        public bool Declaration { get; set; }
        public byte[] ImageData { get; set; } // Add this property
    }

}
