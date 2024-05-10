using Core.Models;
using MongoDB.Driver;
using ServerAPI.Repositories.Interfaces;

namespace ServerAPI.Repositories
{
    public class ApplicationRepository : IApplicationRepository
    {
        private IMongoCollection<Application> collection;
        public ApplicationRepository()
        {
            var client = new MongoClient("mongodb+srv://Marcus:Marc6487@cirkusdb.rxb1kpo.mongodb.net/");
            var database = client.GetDatabase("CirkusDB");
            collection = database.GetCollection<Application>("Applications");
        }
        
        public List<Application> GetAllApplications() 
        {
            List<Application> liste = new();
            return liste;
        }

        public void AddApplication(Application application)
        {

        }

        public void RemoveApplicationByID(int applicationID) 
        { 
        
        }
    }
}
