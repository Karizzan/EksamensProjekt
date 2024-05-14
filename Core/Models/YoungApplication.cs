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
		public string AParentName { get; set; }
		public int AParentPhoneNr { get; set; }
		public string AParentMail { get; set; }
		public bool IsSigned {  get; set; } = false;
		public string AName { get; set; }
		public string APhoneNr { get; set; }
		public string AMail { get; set; }
		public int KræwNr { get; set; }
	}
}
