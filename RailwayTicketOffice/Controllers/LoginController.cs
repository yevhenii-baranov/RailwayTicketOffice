using Microsoft.AspNetCore.Mvc;

namespace RailwayTicketOffice.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }       
    }
}