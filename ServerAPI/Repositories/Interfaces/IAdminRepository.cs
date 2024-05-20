using Core.Models;

namespace ServerAPI.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        public bool CheckLogin(string username, string password);
        public void AddAdmin(Admin admin);

		public List<Admin> GetAllAdmins();

		public void RemoveAdminByID(int adminID);
        public Admin GetAdminByUserName(string username);

	}
}
