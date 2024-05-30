using ServerAPI.Repositories.Interfaces;
using Core.Models;
using MongoDB.Driver;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace ServerAPI.Repositories
{
    // The AdminRepository is used to handle the database operations for the Admin collection
    public class AdminRepository : IAdminRepository
    {
        // The collection is used to access the Admin collection in the database
        private IMongoCollection<Admin> collection;

        // The constructor is used to set the collection to the Admin collection in the database
        public AdminRepository()
        {
            // The client is used to connect to the database
            var client = new MongoClient("mongodb+srv://marcushoumark:Marcus@cirkusdb.rxb1kpo.mongodb.net/");

            // The database is used to access the CirkusDB database
            var database = client.GetDatabase("CirkusDB");

            // The collection is used to access the Admin collection in the database
            collection = database.GetCollection<Admin>("Admin");
        }

        // The CheckLogin function is used to check if the login is correct
        public bool CheckLogin(string username, string password)
        {
            Admin admin = new();
            var filter1 = Builders<Admin>.Filter.Eq("Username", username);
            var filter2 = Builders<Admin>.Filter.Eq("Password", password);

            admin = collection.Aggregate().Match(filter1).Match(filter2).FirstOrDefault();

            // If the admin is not null and the username and password matches the incoming username and password the function returns true
            if (admin != null && admin.Username == username && admin.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // The AddAdmin function is used to add a new admin to the database
        public void AddAdmin(Admin admin)
        {
            var max = 0;
            // If the collection is not empty the max is set to the highest AdminID in the collection
            if (collection.Count(Builders<Admin>.Filter.Empty) > 0)
            {
                max = collection.Find(Builders<Admin>.Filter.Empty).SortByDescending(r => r.AdminID).Limit(1).ToList()[0].AdminID;
            }
            admin.AdminID = max + 1;

            collection.InsertOne(admin);
        }

        // The GetAllAdmins function is used to get all the admins from the database
        public List<Admin> GetAllAdmins()
        {
            return collection.Find(Builders<Admin>.Filter.Empty).ToList();

        }

        // The RemoveAdminByID function is used to remove an admin from the database by the id
        public void RemoveAdminByID(int adminID)
        {
            var filter = Builders<Admin>.Filter.Eq("AdminID", adminID);
            collection.DeleteOne(filter);
        }

        // The GetAdminByUserName function is used to get an admin from the database by the username
        public Admin GetAdminByUserName(string username)
        {
            var filter = Builders<Admin>.Filter.Eq("Username", username);
            return collection.Find(filter).FirstOrDefault();
        }
    }
}
