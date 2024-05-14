using Core.Models;

namespace ServerAPI.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        public bool CheckLogin(string username, string password);
        public void AddAdmin(Admin admin);
        public void RemoveAdminByID(int admninID);
        public Admin GetAdminByUserName(string username);

	}
}
