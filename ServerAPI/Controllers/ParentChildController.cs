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
		public List<Parent> GetAllParentChilds()
		{
			return mRepo.GetAllParentChilds();
		}

		[HttpPost]
		[Route("add")]
		public void AddParentChild(Parent parentchild)
		{
			mRepo.AddParentChild(parentchild);

		}

		[HttpDelete]
		[Route("delete/{id:int}")]
		public void RemoveParentChildnByMail(string parentmail)
		{
			mRepo.RemoveParentChildnByMail(parentmail);
		}

	}

}
