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
    public class TeacherController : Controller
    {
        private readonly TestContext _context;

        public TeacherController(TestContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult TeacherIndex()
        {
            var test = _context.Teacher.FirstOrDefault();

            Teacher model = new Teacher
            {
                Id = test.Id,
                Name = test.Name,
                Designation = test.Designation,
                Contact = test.Contact
            };

            return View(model);
        }

        public IActionResult ViewClassInformation()
        {
            var test = _context.Classes.ToList();
            ClassList studentModel = new ClassList
            {
                ClassAll = test
            };

            return View(studentModel);
        }
        

        public IActionResult AddMarks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveMarks([Bind("Id, Class, Roll, CourseCode, Exam, Mark")]Marks marks)
        {
            using (var db = _context)
            {

                var test = new Marks
                {
                    Id = marks.Id,
                    Class = marks.Class,
                    Roll = marks.Roll,
                    CourseCode = marks.CourseCode,
                    Exam = marks.Exam,
                    Mark = marks.Mark,
                };

                db.Marks.Add(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewMarks");
        }

        public IActionResult ViewMarks()
        {
            var test = _context.Marks.ToList();
            MarksList marksModel = new MarksList
            {
                MarksAll = test
            };

            return View(marksModel);
        }

        public IActionResult UpdateMarksInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateMarks(int Id, [Bind("Id, Class, Roll, CourseCode, Exam, Mark")]Marks marks)
        {
            using (var db = _context)
            {

                var test = new Marks
                {
                    Id = marks.Id,
                    Class = marks.Class,
                    Roll = marks.Roll,
                    CourseCode = marks.CourseCode,
                    Exam = marks.Exam,
                    Mark = marks.Mark,
                };

                db.Marks.Update(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewMarks");
        }

        public IActionResult DeleteMarksInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteMarks(int Id, [Bind("Id, Class, Roll, CourseCode, Exam, Mark")]Marks marks)
        {
            using (var db = _context)
            {

                var test = new Marks
                {
                    Id = marks.Id,
                    Class = marks.Class,
                    Roll = marks.Roll,
                    CourseCode = marks.CourseCode,
                    Exam = marks.Exam,
                    Mark = marks.Mark,
                };

                db.Marks.Remove(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewMarks");
        }
    }
}
