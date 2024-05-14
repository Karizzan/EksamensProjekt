using Core.Models;
using MongoDB.Driver;
using ServerAPI.Repositories.Interfaces;
namespace ServerAPI.Repositories
{
    public class EventRepository : IEventRepository
    {
        private IMongoCollection<Event> collection;
        public EventRepository()
        {
            var client = new MongoClient("mongodb+srv://marcushoumark :Marc6487@cirkusdb.rxb1kpo.mongodb.net/");
            var database = client.GetDatabase("CirkusDB");
            collection = database.GetCollection<Event>("Event");
        }
		public List<Event> GetAllEvents()
		{
			return collection.Find(Builders<Event>.Filter.Empty).ToList();
		}

		public void AddEvent(Event Event)
		{
			collection.InsertOne(Event);
		}

		public void RemoveEventByID(int EventID)
		{
			var filter = Builders<Event>.Filter.Eq("EventID", EventID);
			collection.DeleteOne(filter);
		}
	}
}
