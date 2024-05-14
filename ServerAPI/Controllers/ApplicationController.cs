﻿using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories.Interfaces;
using Core.Models;

namespace ServerAPI.Controllers
{
	[ApiController]
	[Route("application")]
	public class ApplicationController : ControllerBase
    {
			private IApplicationRepository mRepo;

			public ApplicationController(IApplicationRepository repo)
			{
				mRepo = repo;
			}

			[HttpGet]
			[Route("getAll")]
			public List<Application> GetAllApplications()
			{
				return mRepo.GetAllApplications();
			}

			[HttpPost]
			[Route("add")]
			public void AddApplication(Application application)
			{
				mRepo.AddApplication(application);

			}

			[HttpDelete]
			[Route("delete/{id:int}")]
			public void RemoveApplicationByID(int applicationID)
			{
				mRepo.RemoveApplicationByID(applicationID);
			}

	}
}