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

		public List<Parent> GetAllParentChilds()
		{
			return ParentChildCollection.Find(Builders<Parent>.Filter.Empty).ToList();
		}

		public void AddParentChild(Parent parentchild)
		{
			ParentChildCollection.InsertOne(parentchild);
		}

		public void RemoveParentChildnByMail(string parentmail)
		{
			var filter = Builders<Parent>.Filter.Eq("ParentMail", parentmail);
			ParentChildCollection.DeleteOne(filter);
		}
	}
}
