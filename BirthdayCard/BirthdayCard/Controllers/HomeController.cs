using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BirthdayCard.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendCard(Models.GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("SendCard", guestResponse);
            }
            return View("Index");
        }
    }
}