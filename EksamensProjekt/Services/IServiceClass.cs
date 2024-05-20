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
    }
}