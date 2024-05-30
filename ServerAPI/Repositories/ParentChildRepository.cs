using Core.Models;
using MongoDB.Driver;
using ServerAPI.Repositories.Interfaces;

namespace ServerAPI.Repositories
{
	// The EventRepository is used to handle the database operations for the Parent collection
	public class ParentChildRepository : IParentChildRepository
	{
		// The ParentChildCollection is used to access the Parent collection in the database
		private IMongoCollection<Parent> ParentChildCollection;

		// The constructor is used to set the ParentChildCollection to the Parent collection in the database
		public ParentChildRepository()
		{
			// The client is used to connect to the database
			var client = new MongoClient("mongodb+srv://marcushoumark:Marcus@cirkusdb.rxb1kpo.mongodb.net/");

			// The database is used to access the CirkusDB database
			var database = client.GetDatabase("CirkusDB");

			// The ParentChildCollection is used to access the Parent collection in the database
			ParentChildCollection = database.GetCollection<Parent>("Parent");
		}

		// The GetAllParentChilds function is used to get all the parentchilds from the database
		public List<Parent> GetAllParentChilds()
		{
			return ParentChildCollection.Find(Builders<Parent>.Filter.Empty).ToList();
		}

		// The AddParentChild function is used to add a new parentchild to the database
		public void AddParentChild(Parent parentchild)
		{
			ParentChildCollection.InsertOne(parentchild);
		}

		// The RemoveParentChildByID function is used to remove a parentchild from the database by the id
		public void RemoveParentChildnByMail(string parentmail)
		{
			var filter = Builders<Parent>.Filter.Eq("ParentMail", parentmail);
			ParentChildCollection.DeleteOne(filter);
		}
	}
}
