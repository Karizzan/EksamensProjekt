using ServerAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace ServerAPI.Controllers
{
    
        [ApiController]
        [Route("admin")]
        public class AdminController : ControllerBase
        {
            private IAdminRepository mRepo;

            public AdminController(IAdminRepository repo)
            {
                mRepo = repo;
            }


            [HttpPost]
            [Route("add")]
            public void AddAdmin(Admin admin)
            {
                mRepo.AddAdmin(admin);

            }


		[HttpGet]
		[Route("getAll")]
		public List<Admin> GetAllAdmins()
		{
			return mRepo.GetAllAdmins();
		}



		[HttpDelete]
            [Route("delete/{id:int}")]
            public void RemoveAdminByID(int id)
            {
                mRepo.RemoveAdminByID(id);
            }


            [HttpGet]
            [Route("getbyusername/{username}")]
            public Admin GetAdminByUserName(string username)
            {
                return mRepo.GetAdminByUserName(username);
            }

            [HttpGet]
            [Route("checklogin")]
            public bool CheckLogin(string username, string password) 
            { 
               return mRepo.CheckLogin(username, password);
            
            }

        }
    }

