using Core.Models;

namespace ServerAPI.Repositories.Interfaces
{
    // The IAdminRepository is used to define the functions that the AdminRepository must implement
    public interface IAdminRepository
    {
        // The CheckLogin function is used to check if the login is correct
        public bool CheckLogin(string username, string password);

        // The AddAdmin function is used to add a new admin to the database
        public void AddAdmin(Admin admin);

        // The GetAllAdmins function is used to get all the admins from the database
        public List<Admin> GetAllAdmins();

        // The RemoveAdminByID function is used to remove an admin from the database by the id
        public void RemoveAdminByID(int adminID);

        // The GetAdminByUserName function is used to get an admin from the database by the username
        public Admin GetAdminByUserName(string username);

    }
}
