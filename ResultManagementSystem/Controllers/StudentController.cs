using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResultManagementSystem.Data;
using ResultManagementSystem.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResultManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly TestContext _context;

        public StudentController(TestContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult StudentIndex()
        {
            var test = _context.Student.FirstOrDefault();

            Student model = new Student
            {
                Id = test.Id,
                Name = test.Name,
                Class = test.Class,
                Roll = test.Roll,
                Contact = test.Contact
            };
            return View(model);
        }
        

        public IActionResult StudentResult()
        {
            var test = _context.Actor.ToList();
            ActorList actorModel = new ActorList
            {

                ActorAll = test
            };

            return View(actorModel);
        }

        [HttpPost]
        public IActionResult StudentResult(string Id)
        {
            var test = _context.Marks.Where(a => a.Exam == Id).ToList();
            MarksList marksModel = new MarksList
            {

                MarksAll = test
            };

            return View(marksModel);
        }
    }
}
