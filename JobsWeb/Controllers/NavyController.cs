using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobsWeb.Controllers
{
    public class NavyController : Controller
    {
        private readonly JobWebsiteContext context;

        public NavyController(JobWebsiteContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var test = (from c in context.Jobs select c).ToList();
            return View();
        }
    }
}