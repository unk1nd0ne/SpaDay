using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (ViewBag.user == null)
            {
                return Redirect("User/Add");
            }
            return View();
        }

        [HttpGet("Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("Add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (newUser.Password != verify)
            {
                ViewBag.error = "Passwords Need to Match";
                ViewBag.name = newUser.Name;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
            else
            {
                ViewBag.error = "";
                ViewBag.user = newUser;
            }
            return View("Index");
        }
    }
}
