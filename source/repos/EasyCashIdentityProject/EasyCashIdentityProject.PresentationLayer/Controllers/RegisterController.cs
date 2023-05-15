using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

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
            if (!ModelState.IsValid)
                return View(appUserRegisterDtos);

            var random = new Random();
            var appUser = new AppUser
            {
                UserName = appUserRegisterDtos.UserName,
                Email = appUserRegisterDtos.Email,
                Name = appUserRegisterDtos.Name,
                LastName = appUserRegisterDtos.Surname,
                City = "aaaa",
                ImageUrl = "cccc",
                ConfirmCode = random.Next(100000, 1000000).ToString()
            };

            var result = await _userManager.CreateAsync(appUser, appUserRegisterDtos.Password);
            if (!result.Succeeded)
                return View(appUserRegisterDtos);

            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Easy Cash Admin", "atilla.kalayy@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", appUser.Email));
            mimeMessage.Subject = "Easy Cash Onay Kodu";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Kayıt işlemini gerçekleştirmek için onay kodunuz: {appUser.ConfirmCode}";
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate("atilla.kalayy@gmail.com", "ofuvsooeyqshwfow\r\n");
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);
            }

            return RedirectToAction("Index", "ConfirmEmail");
        }
    }
}