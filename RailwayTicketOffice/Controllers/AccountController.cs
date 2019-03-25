using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RailwayTicketOffice.Models;
using RailwayTicketOffice.Service;
using AuthenticationService = RailwayTicketOffice.Service.AuthenticationService;

namespace RailwayTicketOffice.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly AuthenticationService _service = new AuthenticationService();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var email = model.Email;
                    var password = model.Password;
                    ModelState.Clear();
                    _service.Authenticate(email, password, HttpContext);
                    return RedirectToAction("Index", "Dashboard");
                }
                ModelState.AddModelError("SubmitButton", "Email or password you entered is not correct. \n" +
                                                         "Please try again.");
            }
            catch (CannotAuthenticateUser e)
            {
            }
            
            return RedirectToAction("Login");
        }

        public IActionResult Logout()
        {
            _service.LogOut(HttpContext);
            return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}