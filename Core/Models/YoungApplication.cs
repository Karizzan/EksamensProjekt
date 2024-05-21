using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Core.Models
{
    public class YoungApplication
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public int YoungApplicationID { get; set; }

        // Young Applicant Information
        public string AName { get; set; } // Navn
        public string AMail { get; set; } // Email
        public string AParentName { get; set; } // Forældre
        public string AParentPhoneNr { get; set; } // Telefonnr på forældre
        public string AParentMail { get; set; } // Forældre email
        public int KræwNr { get; set; } // Kræw nummer


        // Verification
        public bool AVerified { get; set; } = false; // Verified

        // Signature
        public string Signature { get; set; } // Underskrift
        public byte[] SignatureImage { get; set; }
        // Declaration
        public bool Declaration { get; set; } // Tilkendegivelse (check mark)
    }
}
