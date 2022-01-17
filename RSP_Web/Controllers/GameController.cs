using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissors_Core;

namespace RSP_Web.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
       
        public IActionResult Won()
        {
            return View();
        }
        public IActionResult Drow()
        {
            return View();
        }
        public IActionResult Victory()
        {
            return View();
        }
        // неиспользованный кусок кода, удалить
        /*  [HttpPost]
        public IActionResult Add(Project project)
        {
            ProjectStorage.Add(project);
            return RedirectToAction("Index");
        }*/
    }
}
