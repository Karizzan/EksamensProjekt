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
			Admin admin = new();
			var filter1 = Builders<Admin>.Filter.Eq("Username", username);
			var filter2 = Builders<Admin>.Filter.Eq("Password", password);

			admin = collection.Aggregate().Match(filter1).Match(filter2).FirstOrDefault();

			if (admin != null && admin.Username == username && admin.Password == password)
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

		public List<Admin> GetAllAdmins()
		{
			return collection.Find(Builders<Admin>.Filter.Empty).ToList();

		}

		public void RemoveAdminByID(int adminID)
        {
			var filter = Builders<Admin>.Filter.Eq("AdminID", adminID);
			collection.DeleteOne(filter);
		}

		public Admin GetAdminByUserName(string username)
        {
			var filter = Builders<Admin>.Filter.Eq("Username", username);
			return collection.Find(filter).FirstOrDefault();
        }
	}
}
