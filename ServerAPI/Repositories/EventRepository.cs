using Core.Models;
using MongoDB.Driver;
using ServerAPI.Repositories.Interfaces;
namespace ServerAPI.Repositories
{
    // The EventRepository is used to handle the database operations for the Event collection
    public class EventRepository : IEventRepository
    {
        // The collection is used to define the collection to be used in the database
        private IMongoCollection<Event> collection;

        // The builder is used to set the client adresse, database and collection to be used later on by the rest of the repository
        public EventRepository()
        {
            // The client is used to connect to the database
            var client = new MongoClient("mongodb+srv://marcushoumark:Marcus@cirkusdb.rxb1kpo.mongodb.net/");

            // The database is used to access the CirkusDB database
            var database = client.GetDatabase("CirkusDB");

            // The collection is used to access the Event collection in the database
            collection = database.GetCollection<Event>("Event");
        }

        // Function gets alle events from the database and returns them as a list
        public List<Event> GetAllEvents()
        {
            return collection.Find(Builders<Event>.Filter.Empty).ToList();
        }

        // Function creates a new id and places it on the incoming event and inserts it into the database
        public void AddEvent(Event Event)
        {
            var max = 0;
            // If the collection is not empty the max is set to the highest EventID in the collection
            if (collection.Count(Builders<Event>.Filter.Empty) > 0)
            {
                max = collection.Find(Builders<Event>.Filter.Empty).SortByDescending(r => r.EventID).Limit(1).ToList()[0].EventID;
            }
            Event.EventID = max + 1;
            collection.InsertOne(Event);
        }

        // Function uses the weeknumber to find and delete any events that contain this week number
        public void RemoveEventByWeekNumber(int weekNumber)
        {
            var filter = Builders<Event>.Filter.Eq("WeekNumber", weekNumber);
            collection.DeleteMany(filter);

        }

        // Function searches the database for events matching the id of the given event ant updates the application list of the found event with that of the incoming event
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
