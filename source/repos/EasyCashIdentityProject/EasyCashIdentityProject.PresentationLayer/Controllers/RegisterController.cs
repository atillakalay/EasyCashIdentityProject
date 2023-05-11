using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDtos appUserRegisterDtos)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDtos.UserName,
                    Email = appUserRegisterDtos.Email,
                    Name = appUserRegisterDtos.Name,
                    LastName = appUserRegisterDtos.Surname,
                    City = "aaaa",
                    ImageUrl = "cccc",
                };
                var result = await _userManager.CreateAsync(appUser, appUserRegisterDtos.Password);

                if (result.Succeeded) { return RedirectToAction("Index", "ConfirmEmail"); }
            }

            return View(appUserRegisterDtos);
        }
    }
}
