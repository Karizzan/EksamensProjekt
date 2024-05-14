using ServerAPI.Repositories.Interfaces;
using Core.Models;
using MongoDB.Driver;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace ServerAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private IMongoCollection<Admin> collection;
        public AdminRepository()
        {
            var client = new MongoClient("mongodb+srv://marcushoumark:Marcus@cirkusdb.rxb1kpo.mongodb.net/");
            var database = client.GetDatabase("CirkusDB");
            collection = database.GetCollection<Admin>("Admin");
        }
        public bool CheckLogin(string username, string password)
        {
			Admin admnin = new();
			var filter1 = Builders<Admin>.Filter.Eq("Username", username);
			var filter2 = Builders<Admin>.Filter.Eq("Password", password);

			admnin = collection.Aggregate().Match(filter1).Match(filter2).FirstOrDefault();

			if (admnin != null && admnin.Username == username && admnin.Password == password)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

        public void AddAdmin(Admin admin) 
        {
			collection.InsertOne(admin);
		}
            
        public void RemoveAdminByID(int admninID)
        {
			var filter = Builders<Admin>.Filter.Eq("AdmninID", admninID);
			collection.DeleteOne(filter);
		}

		public Admin GetAdminByUserName(string username)
        {
			var filter = Builders<Admin>.Filter.Eq("Username", username);
			return collection.Find(filter).FirstOrDefault();
        }
	}
}
