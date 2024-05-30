using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories.Interfaces;
using Core.Models;
using static System.Net.WebRequestMethods;

namespace ServerAPI.Controllers
{
    // The ApplicationController is used to handle all the requests that are made to the server that are related to the Applications and YoungApplications
    [ApiController]
    [Route("application")]
    // The ApplicationController is a child of the ControllerBase
    public class ApplicationController : ControllerBase
    {
        // The mRepo is used to access the ApplicationRepository
        private IApplicationRepository mRepo;

        // The constructor is used to set the mRepo to the incoming repo
        public ApplicationController(IApplicationRepository repo)
        {
            mRepo = repo;
        }

        // The GetAllApplications function is used to get all the applications from the database
        [HttpGet]
        [Route("getAll")]
        public List<Application> GetAllApplications()
        {
            return mRepo.GetAllApplications();
        }

        // The AddApplication function is used to add a new application to the database
        [HttpPost]
        [Route("add")]
        public void AddApplication(Application application)
        {
            mRepo.AddApplication(application);
        }

        // The RemoveApplicationByID function is used to remove an application from the database by the id
        [HttpDelete]
        [Route("delete/{id:int}")]
        public void RemoveApplicationByID(int id)
        {
            mRepo.RemoveApplicationByID(id);
        }

        // The UpdateApplication function is used to update an application in the database
        [HttpPut]
        [Route("update")]
        public void UpdateApplication(Application application)
        {
            mRepo.UpdateApplication(application);
        }

        // The GetAllYoungApplications function is used to get all the young applications from the database
        [HttpGet]
        [Route("getAllYoung")]
        public List<YoungApplication> GetAllYoungApplications()
        {
            return mRepo.GetAllYoungApplications();
        }

        // The AddYoungApplication function is used to add a new young application to the database
        [HttpPost]
        [Route("addYoung")]
        public void AddYoungApplication(YoungApplication application)
        {
            mRepo.AddYoungApplication(application);
        }


        // The RemoveYoungApplicationByID function is used to remove a young application from the database by the id
        [HttpDelete]
        [Route("deleteYoung/{id:int}")]
        public void RemoveYoungApplicationByID(int applicationID)
        {
            mRepo.RemoveYoungApplicationByID(applicationID);
        }

        // The UpdateYoungApplication function is used to update a young application in the database
        [HttpPut]
        [Route("update")]
        public void UpdateYoungApplication(YoungApplication application)
        {
            mRepo.UpdateYoungApplication(application);
        }

        // The GetAllLegacyApplication function is used to get all the legacy applications from the database
        [HttpGet]
        [Route("getalllegacy")]
        public List<Application> GetAllLegacyApplication()
        {
            return mRepo.GetAllLegacyApplication();
        }

    }
}
