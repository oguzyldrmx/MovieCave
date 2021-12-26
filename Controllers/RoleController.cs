using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieCave.Models;
using System.Threading.Tasks;

namespace MovieCave.Controllers
{
    [Authorize(Roles = "Admin")]

    public class RoleController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SiteRole role)
        {
            var roleExist = await roleManager.RoleExistsAsync(role.RoleName);
            if (!roleExist)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(role.RoleName));
            }
            return View();
        }
    }
}
