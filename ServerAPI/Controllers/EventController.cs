using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories.Interfaces;
using Core.Models;

namespace ServerAPI.Controllers
{
    // The EventController is used to handle all the requests that are made to the server that are related to the Events
    [ApiController]
    [Route("event")]
    // The EventController is a child of the ControllerBase
    public class EventController : ControllerBase
    {
        // The mRepo is used to access the EventRepository
        private IEventRepository mRepo;

        // The constructor is used to set the mRepo to the incoming repo
        public EventController(IEventRepository repo)
        {
            mRepo = repo;
        }

        // The GetAllEvents function is used to get all the events from the database
        [HttpGet]
        [Route("getAll")]
        public List<Event> GetAllEvents()
        {
            return mRepo.GetAllEvents();
        }

        // The AddEvent function is used to add a new event to the database
        [HttpPost]
        [Route("add")]
        public void AddEvent(Event Event)
        {
            mRepo.AddEvent(Event);

        }

        // The RemoveEventByWeekNumber function is used to remove an event from the database by the week number
        [HttpDelete]
        [Route("delete/{id:int}")]
        public void RemoveEventByWeekNumber(int id)
        {
            mRepo.RemoveEventByWeekNumber(id);
        }

        // The UpDateEvent function is used to update an event in the database
        [HttpPut]
        [Route("update")]
        public void UpDateEvent([FromBody] Event Event)
        {
            mRepo.UpDateEvent(Event);
        }

    }
}
