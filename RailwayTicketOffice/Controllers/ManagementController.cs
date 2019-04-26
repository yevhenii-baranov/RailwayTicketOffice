using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RailwayTicketOffice.Entity;
using RailwayTicketOffice.Models;
using RailwayTicketOffice.Service;

namespace RailwayTicketOffice.Controllers
{
    public class ManagementController : Controller
    {

        public IActionResult Show()
        {
            return View();
        }
    }
}