using FreeCourse.IdentityServer.Dtos;
using FreeCourse.IdentityServer.Models;
using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserManager<ApplicationUser> _userManager;
        [HttpPost]

        public async Task<IActionResult> SingUp(SignUpDto signUp)
        {
            var user = new ApplicationUser
            {
                UserName = signUp.Username,
                Email = signUp.Email,
                City = signUp.City,
            };
            var result = await _userManager.CreateAsync(user,signUp.Password);

            if(!result.Succeeded)
            {
                return BadRequest(Response<NoContent>.Fail(result.Errors.Select(x=>x.Description).ToList(),400)); 
            }

            return NoContent();

        }
    }
}
