namespace ServerAPI.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        public bool CheckLogin(string username, string password);
        public void AddAdmin(string username, string password);
    }
}
