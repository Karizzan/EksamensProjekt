using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    // The IEventRepository is used to define the functions that the EventRepository must implement
    public interface IEventRepository
    {
        // The GetAllEvents function is used to get all the events from the database
        public List<Event> GetAllEvents();

        // The AddEvent function is used to add a new event to the database
        public void AddEvent(Event Event);

        // The RemoveEventByWeekNumber function is used to remove an event from the database by the week number
        public void RemoveEventByWeekNumber(int eventID);

        // The UpDateEvent function is used to update an event in the database
        public void UpDateEvent(Event Event);

    }
}
