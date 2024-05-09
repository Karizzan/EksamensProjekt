using ServerAPI.Repositories.Interfaces;
using Core.Models;
using MongoDB.Driver;

namespace ServerAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private IMongoCollection<Admin> collection;
        public AdminRepository()
        {
            var client = new MongoClient("mongodb+srv://Marcus:Marc6487@cirkusdb.rxb1kpo.mongodb.net/");
            var database = client.GetDatabase("CirkusDB");
            collection = database.GetCollection<Admin>("Admin");
        }
        public bool CheckLogin(string username, string password)
        {
            return true;
        }

        public void AddAdmin(Admin admin) 
        { 

        }

        public void RemoveAdminByID(int admninID)
        {

        }

		public string GetAdminByUserName(string username)
        {
            return "Admin";
        }
	}
}
