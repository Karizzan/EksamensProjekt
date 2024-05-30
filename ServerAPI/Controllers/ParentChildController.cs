using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories.Interfaces;
using Core.Models;

namespace ServerAPI.Controllers
{
    // The ParentChildController is used to handle all the requests that are made to the server that are related to the Parent and Child
    [ApiController]
    [Route("parentchild")]
    // The ParentChildController is a child of the ControllerBase
    public class ParentChildController : ControllerBase
    {
        // The mRepo is used to access the ParentChildRepository
        private IParentChildRepository mRepo;

        // The constructor is used to set the mRepo to the incoming repo
        public ParentChildController(IParentChildRepository repo)
        {
            mRepo = repo;
        }

        // The GetAllParentChilds function is used to get all the parentchilds from the database
        [HttpGet]
        [Route("getAll")]
        public List<Parent> GetAllParentChilds()
        {
            return mRepo.GetAllParentChilds();
        }

        // The AddParentChild function is used to add a new parentchild to the database
        [HttpPost]
        [Route("add")]
        public void AddParentChild(Parent parentchild)
        {
            mRepo.AddParentChild(parentchild);

        }

        // The RemoveParentChildByID function is used to remove a parentchild from the database by the id
        [HttpDelete]
        [Route("delete/{id:int}")]
        public void RemoveParentChildnByMail(string parentmail)
        {
            mRepo.RemoveParentChildnByMail(parentmail);
        }

    }

}
