using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResultManagementSystem.Data;
using ResultManagementSystem.Models;

namespace ResultManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestContext _context;

        public HomeController(TestContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Login l)
        {
            using (var db = _context)
           {
                var test = _context.Login.Where(a => a.Id == l.Id && a.Password == l.Password && l.ActorId==1).FirstOrDefault();
                var test1 = _context.Login.Where(a => a.Id == l.Id && a.Password == l.Password && l.ActorId ==2).FirstOrDefault();
                if (test != null)
                    {                    
                    RedirectToAction( "AdminIndex", "Admin");
                            //return View("AdminIndex", "Admin");
                    }
                else if (test1 != null)
                {
                    return View("Contact");
                }
            }
            
          
            return View("Index");
        }       

        public IActionResult About()
        {
            ViewData["Message"] = "About Western Laboratory School";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact here:";

            return View();
        }

        public IActionResult AdminIndex()
        {
            ViewData["Message"] = "Admin";

            return View();
        }

        public IActionResult RegiserIndex()
        {
            ViewData["Message"] = "Register";

            return View();
        }

        public IActionResult TeacherIndex()
        {
            ViewData["Message"] = "Teacher";

            return View();
        }

        public IActionResult StudentIndex()
        {
            ViewData["Message"] = "Student";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        //public string CheckRadio(FormCollection frm)
        //{

        //    string genderradio = frm["Gender"].ToString();
        //    if(genderradio=="admin")
        //    return View("RegisterIndex");
        //}
    }
}
