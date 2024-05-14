using Core.Models;
using MongoDB.Driver;
using ServerAPI.Repositories.Interfaces;

namespace ServerAPI.Repositories
{
    public class ParentChildRepository : IParentChildRepository
    {
        private IMongoCollection<Parent> ParentChildCollection;
        public ParentChildRepository()
        {
            var client = new MongoClient("mongodb+srv://Marcus:Marc6487@cirkusdb.rxb1kpo.mongodb.net/");
            var database = client.GetDatabase("CirkusDB");
            ParentChildCollection = database.GetCollection<Parent>("Parent");
        }

        public List<Parent> GetAllParents()
        {
            return ParentChildCollection.Find(p => true).ToList();
        }
        public void AddParent(Parent parent)
        {

        }
        public void RemoveParentByID(int parentID)
        {

        }
    }
}
