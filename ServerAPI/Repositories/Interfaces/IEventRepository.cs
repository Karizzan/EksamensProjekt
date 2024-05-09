using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    public interface IEventRepository
    {
        //yeet
        public List<Event> GetAllEvents();
        public void AddEvent(Event Event);
        public void RemoveEventByID(int eventID);
    }
}
