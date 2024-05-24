﻿using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    public interface IEventRepository
    {
        public List<Event> GetAllEvents();
        public void AddEvent(Event Event);
        public void RemoveEventByWeekNumber(int eventID);
        public void UpDateEvent(Event Event);

	}
}
