using HexaReportApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace HexaReportApp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/Account")]
    public class AccountController : Controller
    {
        private readonly CtimeContext _context;

        public AccountController(CtimeContext context)
        {
            _context = context;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string LoginName, string password)
        {
            var account = _context.Logins.FirstOrDefault(s => s.LoginName == LoginName && s.Password == password);

            if (account != null)
            {
                // Successful login
                // Redirect to the desired page or perform other actions
                return RedirectToAction("Index", "Dashboard", new { area = "admin" });
            }
            else
            {
                // Invalid login
                // Handle the error, e.g., display an error message
                ViewBag.error= "Invalid login attempt.";
                return View("Index");
            }

           


        }
    }
}
