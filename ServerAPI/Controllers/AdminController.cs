using ServerAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace ServerAPI.Controllers
{

	// The AdminController is used to handle all the requests that are made to the server that are related to the Admins
	[ApiController]
	[Route("admin")]
	// The AdminController is a child of the ControllerBase
	public class AdminController : ControllerBase
	{
		// The mRepo is used to access the AdminRepository
		private IAdminRepository mRepo;

		// The constructor is used to set the mRepo to the incoming repo
		public AdminController(IAdminRepository repo)
		{
			mRepo = repo;
		}


		// The AddAdmin function is used to add a new admin to the database
		[HttpPost]
		[Route("add")]
		public void AddAdmin(Admin admin)
		{
			mRepo.AddAdmin(admin);

		}


		// The GetAllAdmins function is used to get all the admins from the database
		[HttpGet]
		[Route("getAll")]
		public List<Admin> GetAllAdmins()
		{
			return mRepo.GetAllAdmins();
		}


		// The RemoveAdminByID function is used to remove an admin from the database by the id
		[HttpDelete]
		[Route("delete/{id:int}")]
		public void RemoveAdminByID(int id)
		{
			mRepo.RemoveAdminByID(id);
		}

		// The UpdateAdmin function is used to update an admin in the database
		[HttpGet]
		[Route("getbyusername/{username}")]
		public Admin GetAdminByUserName(string username)
		{
			return mRepo.GetAdminByUserName(username);
		}

		//The checklogin function is used to check if the login is correct
		[HttpGet]
		[Route("checklogin")]
		public bool CheckLogin(string username, string password)
		{
			return mRepo.CheckLogin(username, password);

		}

	}
}

