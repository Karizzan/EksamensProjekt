using Core.Models;
using MongoDB.Driver;
using ServerAPI.Repositories.Interfaces;

namespace ServerAPI.Repositories
{
    // The ApplicationRepository is used to handle the database operations for the Application collection, YoungApplication collection and LegacyApplication collection
    public class ApplicationRepository : IApplicationRepository
    {
        // The AppCollection is used to access the Application collection in the database
        private IMongoCollection<Application> AppCollection;

        // The YAppCollection is used to access the YoungApplication collection in the database
        private IMongoCollection<YoungApplication> YAppCollection;

        // The LAppCollection is used to access the LegacyApplication collection in the database
        private IMongoCollection<Application> LAppCollection;

        // The builder is used to set the client adresse, database and collections to be used later on by the rest of the repository
        public ApplicationRepository()
        {
            // The client is used to connect to the database
            var client = new MongoClient("mongodb+srv://marcushoumark:Marcus@cirkusdb.rxb1kpo.mongodb.net/");

            // The database is used to access the CirkusDB database
            var database = client.GetDatabase("CirkusDB");

            // The collections are used to access the Application, YoungApplication and LegacyApplication collections in the database
            AppCollection = database.GetCollection<Application>("Application");
            YAppCollection = database.GetCollection<YoungApplication>("YoungApplication");
            LAppCollection = database.GetCollection<Application>("LegacyApplication");
        }

        // Function gets all applications from the database and returns them as a list
        public List<Application> GetAllApplications()
        {
            return AppCollection.Find(Builders<Application>.Filter.Empty).ToList();

        }

        // Function creates a new id and places it on the incoming application and inserts it into the database
        public void AddApplication(Application application)
        {
            var max = 0;
            // If the collection is not empty the max is set to the highest ApplicationID in the collection
            if (AppCollection.Count(Builders<Application>.Filter.Empty) > 0)
            {
                max = LAppCollection.Find(Builders<Application>.Filter.Empty).SortByDescending(r => r.ApplicationID).Limit(1).ToList()[0].ApplicationID;
            }
            application.ApplicationID = max + 1;
            AppCollection.InsertOne(application);
            LAppCollection.InsertOne(application);
        }


        // Function uses the id to find and delete any application that contain this id
        public void RemoveApplicationByID(int id)
        {

            var filter = Builders<Application>.Filter.Eq("ApplicationID", id);
            AppCollection.DeleteMany(filter);



        }

        // Function searches the database for applications matching the id of the given application and updates it
        public void UpdateApplication(Application application)
        {
            var filter = Builders<Application>.Filter.Eq("ApplicaitonID", application.ApplicationID);
            var update = Builders<Application>.Update
                .Set(e => e, application);

            // Repeat for all properties of Event that should be updated
            AppCollection.UpdateOne(filter, update);
        }

        // Function gets alle youngapplications from the database and returns them as a list
        public List<YoungApplication> GetAllYoungApplications()
        {
            return YAppCollection.Find(Builders<YoungApplication>.Filter.Empty).ToList();
        }

        // Function creates a new id and places it on the incoming youngapplication and inserts it into the database
        public void AddYoungApplication(YoungApplication youngApplication)
        {
            var max = 0;

            // If the collection is not empty the max is set to the highest YoungApplicationID in the collection
            if (YAppCollection.Count(Builders<YoungApplication>.Filter.Empty) > 0)
            {
                max = YAppCollection.Find(Builders<YoungApplication>.Filter.Empty).SortByDescending(r => r.YoungApplicationID).Limit(1).ToList()[0].YoungApplicationID;
            }
            youngApplication.YoungApplicationID = max + 1;
            YAppCollection.InsertOne(youngApplication);
        }

        // Function uses the id to find and delete any youngapplication that contain this id
        public void RemoveYoungApplicationByID(int youngApplicationID)
        {
            var filter = Builders<YoungApplication>.Filter.Eq("YoungApplicationID", youngApplicationID);
            YAppCollection.DeleteOne(filter);
        }

        // Function searches the database for a youngapplication matching the id of the given youngapplication and updates it
        public void UpdateYoungApplication(YoungApplication youngApplication)
        {
            var filter = Builders<YoungApplication>.Filter.Eq("YoungApplicationID", youngApplication.YoungApplicationID);
            var update = Builders<YoungApplication>.Update
                .Set(e => e, youngApplication);
            YAppCollection.UpdateOne(filter, update);
        }

        // Function gets alle legacyapplications from the database and returns them as a list
        public List<Application> GetAllLegacyApplication()
        {
            return LAppCollection.Find(Builders<Application>.Filter.Empty).ToList();
        }

    }

}
