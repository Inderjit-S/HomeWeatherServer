using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicServer.Data.Models;
using MusicServer.Data;
using Microsoft.EntityFrameworkCore;

namespace MusicServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController(ApplicationDbContext db,
        UserManager<ApplicationUser> userManager) : ControllerBase
    {

        [HttpPost("User")]
        public async Task<ActionResult> SeedUser()
        {
            (string name, string email) = ("user1", "comp584@csun.edu");
            ApplicationUser user = new()
            {
                UserName = name,
                Email = email,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            if (await userManager.FindByNameAsync(name) is not null)
            {
                user.UserName = "user2";
            }
            _ = await userManager.CreateAsync(user, "P@ssw0rd!")
                ?? throw new InvalidOperationException();
            user.EmailConfirmed = true;
            user.LockoutEnabled = false;
            await db.SaveChangesAsync();

            return Ok();
        }
    }
}

