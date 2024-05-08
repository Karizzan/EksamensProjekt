using Core.Models;
using MongoDB.Driver;
using ServerAPI.Repositories.Interfaces;

namespace ServerAPI.Repositories
{
    public class SignUpRepository : ISignUpRepository
    {
        private IMongoCollection<Parent> collection;
        public SignUpRepository()
        {
            var client = new MongoClient("mongodb+srv://Marcus:Marc6487@cirkusdb.rxb1kpo.mongodb.net/");
            var database = client.GetDatabase("CirkusDB");
            collection = database.GetCollection<Parent>("Parents");
        }
        public List<Child> GetAllChildren()
        {
            return
        }
        public List<Parent> GetAllParents()
        {
            return
        }
        public void AddChild(Child child)
        {

        }
    }
}
