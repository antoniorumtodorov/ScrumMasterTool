using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumMasterTool.Controllers
{
    public class GroomingController : Controller
    {
             
        public IActionResult Grooming()
        {
             ViewBag.Title = "Grooming";
            return View();
        }
    }
}
