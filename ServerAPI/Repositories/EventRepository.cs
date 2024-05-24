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
            var client = new MongoClient("mongodb+srv://marcushoumark:Marcus@cirkusdb.rxb1kpo.mongodb.net/");
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

		public void RemoveEventByWeekNumber(int weekNumber)
		{
			var filter = Builders<Event>.Filter.Eq("WeekNumber", weekNumber);
			collection.DeleteMany(filter);
			
		}

		public void UpDateEvent(Event Event)
		{
			var filter = Builders<Event>.Filter.Eq("EventID", Event.EventID);
			var update = Builders<Event>.Update
				.Set(e => e.Applications, Event.Applications)
				// Repeat for all properties of Event that should be updated
				;

			collection.UpdateOne(filter, update);
		}
	}
}
