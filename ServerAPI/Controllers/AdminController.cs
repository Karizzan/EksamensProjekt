using ServerAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace ServerAPI.Controllers
{
    
        [ApiController]
        [Route("admnin")]
        public class AdminController : ControllerBase
        {
            private IAdminRepository mRepo;

            public AdminController(IAdminRepository repo)
            {
                mRepo = repo;
            }


            [HttpPost]
            [Route("add")]
            public void AddAdmin(Admin admnin)
            {
                mRepo.AddAdmin(admnin);

            }



            [HttpDelete]
            [Route("delete/{id:int}")]
            public void RemoveAdminByID(int id)
            {
                mRepo.RemoveAdminByID(id);
            }


            [HttpGet]
            [Route("getbyusername/{username}")]
            public string GetAdminByUserName(string username)
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

