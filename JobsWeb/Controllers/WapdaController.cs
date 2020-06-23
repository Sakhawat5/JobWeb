using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JobsWeb.Controllers
{
    public class WapdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}