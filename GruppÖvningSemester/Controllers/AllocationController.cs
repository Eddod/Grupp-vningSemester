using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GruppÖvningSemester.Controllers
{
    public class AllocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
