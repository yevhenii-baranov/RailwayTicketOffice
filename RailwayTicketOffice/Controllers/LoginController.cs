using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RailwayTicketOffice.Models;
using RailwayTicketOffice.Service;
using AuthenticationService = RailwayTicketOffice.Service.AuthenticationService;

namespace RailwayTicketOffice.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly AuthenticationService _service = new AuthenticationService();
        
        public IActionResult Index(LoginModel model)
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Authenticate(model.Email, model.Password, HttpContext);
                    return RedirectToAction("Index", "Dashboard");
                }
                catch (CannotAuthenticateUser e)
                {
                    return Index(model);
                }
            }
            else return Index(model);
        }

        public IActionResult Logout()
        {
            _service.LogOut(HttpContext);
            return RedirectToAction("Index");
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}