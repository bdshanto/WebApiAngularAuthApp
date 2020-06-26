using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        public ApplicationUserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        
        [HttpPost]
        [Route(("Register"))]
//Api:/api/applicationUser/registration
        public async Task<object>PostApplication(ApplicationUserModel model)
        {
            var applicationUser = new ApplicationUser
            {
                UserName = model.UserName, Email = model.Email, FullName = model.FullName
            };
            try
            {
                var result = _userManager.CreateAsync(applicationUser, model.Password);
                return Ok(result);
            }
            
            catch (Exception e)
            {
                 
                throw e;
            }


        }
    }
}