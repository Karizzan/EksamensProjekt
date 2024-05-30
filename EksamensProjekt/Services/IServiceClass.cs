using System;
using Core.Models;
namespace EksamensProjekt.Services
{
    // The IServiceClass is used to define the functions that the ServiceClass must implement
    public interface IServiceClass
    {
        // The GetAllApplications function is used to get all the applications from the database
        Task<Application[]> GetAllApplications();

        // The AddApplication function is used to add a new application to the database
        Task AddApplication(Application application);

        //The AddAdmin function is used to add a new admin to the database
        Task AddAdmin(Admin admin);

        //The DeleteAdminByID function is used to remove an admin from the database by the id
        Task DeleteAdminByID(int adminID);

        // The GetAllAdmins function is used to get all the admins from the database
        Task<Admin[]> GetAllAdmins();

        //The GetAllEvents function is used to get all the events from the database
        Task<Event[]> GetAllEvents();

        // The AddEvent function is used to add a new event to the database
        Task AddEvent(Event Event);

        // The UpdateEvent function is used to update an event in the database
        Task UpdateEvent(Event Event);

        // The RemoveEventByWeekNumber function is used to remove an event from the database by the week number
        Task RemoveEventByWeekNumber(int weekNumber);

        // The UpdateApplication function is used to update an application in the database
        Task UpdateApplication(Application application);

        // The DeleteApplicationByID function is used to remove an application from the database by the id
        Task DeleteApplicationByID(int id);

        // The GetAllYoungApplications function is used to get all the young applications from the database
        Task<YoungApplication[]> GetAllYoungApplications();

        // The AddYoungApplication function is used to add a new young application to the database
        Task AddYoungApplication(YoungApplication youngApplication);

        // The UpdateYoungApplication function is used to update a young application in the database
        Task UpdateYoungApplication(YoungApplication youngApplication);

        // The DeleteYoungApplicationByID function is used to remove a young application from the database by the id
        Task DeleteYoungApplicationByID(int id);

        // The GetAllLegacyApplication function is used to get all the legacy applications from the database
        Task<Application[]> GetAllLegacyApplication();

        Task AddParentChild(Parent parentChild);

    }
}