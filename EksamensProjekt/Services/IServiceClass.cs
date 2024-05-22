using System;
using Core.Models;
namespace EksamensProjekt.Services
{
    public interface IServiceClass
    {
        Task<Application[]> GetAllApplications();

        Task AddApplication(Application application);

		Task AddAdmin(Admin admin);

        Task DeleteAdminByID(int adminID);

		Task<Admin[]> GetAllAdmins();

		Task<Event[]> GetAllEvents();

        Task AddEvent(Event Event);
        Task UpdateEvent(Event Event);
        bool CheckLogin(string username, string password);
        Task UpdateApplication(Application application);    
        Task DeleteApplicationByID(int id);

        Task<YoungApplication[]> GetAllYoungApplication();

        Task AddYoungApplication(YoungApplication youngApplication);

        Task UpdateYoungApplication(YoungApplication youngApplication);
       

    }
}