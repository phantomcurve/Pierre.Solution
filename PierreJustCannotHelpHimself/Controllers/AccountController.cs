using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PierreJustCannotHelpHimself.Models;
using System.Threading.Tasks;
using PierreJustCannotHelpHimself.ViewModels;

namespace PierreJustCannotHelpHimself.Controllers
{
    public class AccountController : Controller
    {
        private readonly PierreJustCannotHelpHimselfContext _db;
        private readonly UserManager <ApplicationUser> _userManager;
        private readonly SignInManager <ApplicationUser> _signInManager;

        public AccountController(UserManager <ApplicationUser> userManager, SignInManager <ApplicationUser> signInManager, PierreJustCannotHelpHimselfContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            var user = new ApplicationUser { Email = model.Email };
            if (model.Password == model.ConfirmPassword)
            {
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                ViewBag.PasswordNotMatch = "Your passwords didn't match! Try again!";
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await
            _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<ActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}