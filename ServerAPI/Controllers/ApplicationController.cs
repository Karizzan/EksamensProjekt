using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories.Interfaces;
using Core.Models;
using static System.Net.WebRequestMethods;

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
			public void RemoveApplicationByID(int id)
			{
				mRepo.RemoveApplicationByID(id);
			}

		[HttpPut]
		[Route("update")]
		public void UpdateApplication(Application application)
		{
			mRepo.UpdateApplication(application);
		}

		
		[HttpGet]
		[Route("getAllYoung")]
		public List<YoungApplication> GetAllYoungApplications()
		{
			return mRepo.GetAllYoungApplications();
		}

        [HttpPost]
        [Route("addYoung")]
        public void AddYoungApplication (YoungApplication application)
		{
			mRepo.AddYoungApplication(application);
		}



        [HttpDelete]
		[Route("deleteYoung/{id:int}")]
		public void RemoveYoungApplicationByID(int applicationID)
		{
			mRepo.RemoveYoungApplicationByID(applicationID);
		}

		[HttpPut]
		[Route("update")]
		public void UpdateYoungApplication (YoungApplication application)
		{
			mRepo.UpdateYoungApplication(application);
		}

       

    }
}
