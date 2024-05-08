using ServerAPI.Repositories.Interfaces;
using Core.Models;

namespace ServerAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public bool CheckLogin(string username, string password)
        {
            Admin admin = new();
            var filter1 = Builders<Bruger>.Filter.Eq("Email", email);
            var filter2 = Builders<Bruger>.Filter.Eq("Kodeord", kodeord);

            bruger = collection.Aggregate().Match(filter1).Match(filter2).FirstOrDefault();

            if (bruger != null && bruger.Email == email && bruger.Kodeord == kodeord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddAdmin(string username, string password) 
        { 

        }
    }
}
