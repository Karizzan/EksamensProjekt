﻿using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories.Interfaces;
using Core.Models;

namespace ServerAPI.Controllers
{
	[ApiController]
	[Route("event")]
	public class EventController : ControllerBase
	{
		private IEventRepository mRepo;

		public EventController(IEventRepository repo)
		{
			mRepo = repo;
		}

		[HttpGet]
		[Route("getAll")]
		public List<Event> GetAllEvents()
		{
			return mRepo.GetAllEvents();
		}

		[HttpPost]
		[Route("add")]
		public void AddEvent(Event Event)
		{
			mRepo.AddEvent(Event);

		}

		[HttpDelete]
		[Route("delete/{id:int}")]
		public void RemoveEventByID(int eventID)
		{
			mRepo.RemoveEventByID(eventID);
		}

	}
}