using System;
using Core.Models;
namespace EksamensProjekt.Services
{
    public interface IServiceClass
    {
        Task<Application[]> GetAllApplications();

        Task AddApplication(Application application);

		Task AddAdmin(Admin admin);

		Task<Event[]> GetAllEvents();

        Task AddEvent(Event Event);
        Task UpdateEvent(Event Event);
        bool CheckLogin(string username, string password);
    }
}