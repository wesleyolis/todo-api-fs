using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.API.Controllers
{
    public class FrontEndController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
