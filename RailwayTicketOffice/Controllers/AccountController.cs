using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RailwayTicketOffice.Models;
using RailwayTicketOffice.Service;
using AuthenticationService = RailwayTicketOffice.Service.AuthenticationService;

namespace RailwayTicketOffice.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly AuthenticationService _service = new AuthenticationService();
        private ILogger _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            this._logger = logger;
        }
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            _logger.LogInformation("Trying to log user in");
            try
            {
                if (ModelState.IsValid)
                {
                    var email = model.Email;
                    var password = model.Password;
                    
                    _service.Authenticate(email, password, HttpContext);

                    ModelState.Clear();
                    return RedirectToAction("Index", "Dashboard");
                }

                ModelState.AddModelError("SubmitButton", "Email or password you entered is not correct. \n" +
                                                         "Please try again.");
            }
            catch (CannotAuthenticateUser e)
            {
                _logger.LogWarning("User authentication failed: {}", e.Message);
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