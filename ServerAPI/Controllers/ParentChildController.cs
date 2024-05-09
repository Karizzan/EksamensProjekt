using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories.Interfaces;
using Core.Models;

namespace ServerAPI.Controllers
{
	[ApiController]
	[Route("parentchild")]
	public class ParentChildController : ControllerBase
	{
		private IParentChildRepository mRepo;

		public ParentChildController(IParentChildRepository repo)
		{
			mRepo = repo;
		}

		[HttpGet]
		[Route("getAll")]
		public List<Parent> GetAllParents()
		{
			return mRepo.GetAllParents();
		}

		[HttpPost]
		[Route("add")]
		public void AddParent(Parent parent)
		{
			mRepo.AddParent(parent);

		}

		[HttpDelete]
		[Route("delete/{id:int}")]
		public void RemoveParentByID(int parentID)
		{
			mRepo.RemoveParentByID(parentID);
		}

	}

}
