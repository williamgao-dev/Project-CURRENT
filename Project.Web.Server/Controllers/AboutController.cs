using System;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Project.Web.Server
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TellMeMore(string id="")
        {
            return View();
        }
    }
}
