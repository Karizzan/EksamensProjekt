using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    public interface IApplicationRepository
    {
       public List<Application> GetAllApplications();
       public void AddApplication(Application application);
       public void RemoveApplicationByID(int applicationID);
    }
}
