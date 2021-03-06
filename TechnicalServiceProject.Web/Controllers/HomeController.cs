
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TechnicalServiceProject.Data.Identity;
//using TechnicalServiceProject.Core.Identity;
//using TechnicalServiceProject.Data.Identity;

namespace TechnicalServiceProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult DishwasherServices()
        {
            return View();
        }
        public IActionResult WashingMachineServices()
        {
            return View();
        }
        public IActionResult FridgeServices()
        {
            return View();
        }
        public IActionResult OvenServices()
        {
            return View();
        }

        public IActionResult Appoinment()
        {
            return View();
        }

    }
}
