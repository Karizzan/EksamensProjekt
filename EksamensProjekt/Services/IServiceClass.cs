using System;
using Core.Models;
namespace EksamensProjekt.Services
{
    public interface IServiceClass
    {
        Task<Application[]> GetAllApplications();

        Task AddApplication(Application application);

        Task<Event[]> GetAllEvents();

        Task AddYoungApplication(YoungApplication application);

    }
}