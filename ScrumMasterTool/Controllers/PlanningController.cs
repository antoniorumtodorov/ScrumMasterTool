using Microsoft.AspNetCore.Mvc;
using ScrumMasterTool.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumMasterTool.Controllers
{
    public class PlanningController : Controller
    
    {
        private readonly ScrumToolContext _context;
        public PlanningController(ScrumToolContext context)
        {
            _context = context;
        }
        public IActionResult Planning()
        {
            ViewBag.Title = "Planning";

            var results = from member in _context.Members
                          orderby member.Name
                          select member;            

            return View(results.ToList());
        }

        
    } 
}
