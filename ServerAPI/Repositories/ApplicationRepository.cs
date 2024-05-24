using Core.Models;
using MongoDB.Driver;
using ServerAPI.Repositories.Interfaces;

namespace ServerAPI.Repositories
{
	public class ApplicationRepository : IApplicationRepository
	{
		private IMongoCollection<Application> AppCollection;

		private IMongoCollection<YoungApplication> YAppCollection;
		public ApplicationRepository()
		{
			var client = new MongoClient("mongodb+srv://marcushoumark:Marcus@cirkusdb.rxb1kpo.mongodb.net/");
			var database = client.GetDatabase("CirkusDB");
			AppCollection = database.GetCollection<Application>("Application");
			YAppCollection = database.GetCollection<YoungApplication>("YoungApplication");
		}

		public List<Application> GetAllApplications()
		{
			return AppCollection.Find(Builders<Application>.Filter.Empty).ToList();

		}

		public void AddApplication(Application application)
		{
			AppCollection.InsertOne(application);
		}

		public void RemoveApplicationByID(int id)
		{

			var filter = Builders<Application>.Filter.Eq("ApplicationID", id);
			AppCollection.DeleteMany(filter);



		}
		public void UpdateApplication(Application application)
		{
			var filter = Builders<Application>.Filter.Eq("ApplicaitonID", application.ApplicationID);
			var update = Builders<Application>.Update
				.Set(e => e, application);

			// Repeat for all properties of Event that should be updated
			AppCollection.UpdateOne(filter, update);
		}


		public List<YoungApplication> GetAllYoungApplications()
		{
			return YAppCollection.Find(Builders<YoungApplication>.Filter.Empty).ToList();
		}

		public void AddYoungApplication(YoungApplication application)
		{
			YAppCollection.InsertOne(application);
		}

		public void RemoveYoungApplicationByID(int applicationID)
		{
			var filter = Builders<YoungApplication>.Filter.Eq("YoungApplicationID", applicationID);
			YAppCollection.DeleteOne(filter);
		}

	}

}
