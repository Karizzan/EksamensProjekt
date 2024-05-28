using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Parent
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        //public int ParentID { get; set; } Maybe we should add this later

        // This is used to validate the input from the user
        //[Required(ErrorMessage = "Parent Name is required.")]

        [Required(ErrorMessage = "Feltet skal være udfyldt")] 
        public string ParentName { get; set; }
        [Required(ErrorMessage = "Feltet skal være udfyldt")]
        public int KræwNumber { get; set; }

        [Required(ErrorMessage = "Feltet skal være udfyldt")]
        public string ParentMail { get; set; }
        public int ParentPhone { get; set; }
        public List<Child> Children { get; set; } = new List<Child>();
    }
}
