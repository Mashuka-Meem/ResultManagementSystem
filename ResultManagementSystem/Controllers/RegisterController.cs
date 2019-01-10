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
    public class RegisterController : Controller
    {
        private readonly TestContext _context;

        public RegisterController(TestContext context)
        {
            _context = context;
        }

        //GET: /<controller>/

        public IActionResult RegisterIndex()
        {
            return View();
        }

        public IActionResult AddStudentInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveStudent([Bind("Id, Name, Class, Roll, Contact")]Student student)
        {
            using (var db = _context)
            {

                var test = new Student
                {
                    Id = student.Id,
                    Name = student.Name,
                    Class = student.Class,
                    Roll = student.Roll,
                    Contact = student.Contact
                };

                db.Student.Add(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewStudentInformation");
        }

        public IActionResult ViewStudentInformation()
        {
            var test = _context.Student.ToList();
            StudentList studentModel = new StudentList
            {

                StudentAll = test
            };

            return View(studentModel);
        }

        [HttpPost]
        public IActionResult ViewStudentInformation(int? Id)
        {
            var test = _context.Student.Where(a => a.Id == Id).ToList();
            StudentList studentModel = new StudentList
            {

                StudentAll = test
            };

            return View(studentModel);
        }

        public IActionResult UpdateStudentInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateStudent(int Id, [Bind("Id, Name, Class, Roll, Contact")]Student student)
        {
            using (var db = _context)
            {

                var test = new Student
                {
                    Id = student.Id,
                    Name = student.Name,
                    Class = student.Class,
                    Roll = student.Roll,
                    Contact = student.Contact
                };

                db.Student.Update(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewStudentInformation");
        }

        public IActionResult DeleteStudentInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteStudent(int Id, [Bind("Id, Name, Class, Roll, Contact")]Student student)
        {
            using (var db = _context)
            {

                var test = new Student
                {
                    Id = student.Id,
                    Name = student.Name,
                    Class = student.Class,
                    Roll = student.Roll,
                    Contact = student.Contact
                };

                db.Student.Remove(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewStudentInformation");
        }

        public IActionResult AddTeacherInformation()
        {
            return View();
        }   

        [HttpPost]
        public IActionResult SaveTeacher([Bind("Id, Name, Designation, Contact")]Teacher teacher)
        {
            using (var db = _context)
            {

                var test = new Teacher
                {
                    Id = teacher.Id,
                    Name = teacher.Name,
                    Designation = teacher.Designation,
                    Contact = teacher.Contact
                };

                db.Teacher.Add(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewTeacherInformation");
        }

        public IActionResult ViewTeacherInformation()
        {
            var test = _context.Teacher.ToList();
            TeacherList teacherModel = new TeacherList
            {
                TeacherAll = test
            };

            return View(teacherModel);
        }

        [HttpPost]
        public IActionResult ViewTeacherInformation(int? Id)
        {
            var test = _context.Teacher.Where(a => a.Id == Id).ToList();
            TeacherList teacherModel = new TeacherList
            {
                TeacherAll = test
            };

            return View(teacherModel);
        }

        public IActionResult UpdateTeacherInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateTeacher(int Id, [Bind("Id, Name, Designation, Contact")]Teacher teacher)
        {
            using (var db = _context)
            {

                var test = new Teacher
                {
                    Id = teacher.Id,
                    Name = teacher.Name,
                    Designation = teacher.Designation,
                    Contact = teacher.Contact
                };

                db.Teacher.Update(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewTeacherInformation");
        }

        public IActionResult DeleteTeacherInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteTeacher(int Id, [Bind("Id, Name, Designation, Contact")]Teacher teacher)
        {
            using (var db = _context)
            {

                var test = new Teacher
                {
                    Id = teacher.Id,
                    Name = teacher.Name,
                    Designation = teacher.Designation,
                    Contact = teacher.Contact
                };

                db.Teacher.Remove(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewTeacherInformation");
        }

        public IActionResult AddCourseInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveCourse([Bind("CourseCode, CourseName")]Course course)
        {
            using (var db = _context)
            {

                var test = new Course
                {
                    CourseCode = course.CourseCode,
                    CourseName = course.CourseName
                };

                db.Course.Add(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewCourseInformation");
        }

        public IActionResult ViewCourseInformation()
        {
            var test = _context.Course.ToList();
            CourseList courseModel = new CourseList
            {
                CourseAll = test
            };

            return View(courseModel);
        }

        [HttpPost]
        public IActionResult ViewCourseInformation(int? Id)
        {
            var test = _context.Course.Where(a => a.CourseCode == Id).ToList();
            CourseList courseModel = new CourseList
            {
                CourseAll = test
            };

            return View(courseModel);
        }

        public IActionResult UpdateCourseInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCourse(int Id, [Bind("CourseCode, CourseName")]Course course)
        {
            using (var db = _context)
            {

                var test = new Course
                {
                    CourseCode = course.CourseCode,
                    CourseName = course.CourseName
                };

                db.Course.Update(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewCourseInformation");
        }

        public IActionResult DeleteCourseInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteCourse(int Id, [Bind("CourseCode, CourseName")]Course course)
        {
            using (var db = _context)
            {

                var test = new Course
                {
                    CourseCode = course.CourseCode,
                    CourseName = course.CourseName
                };

                db.Course.Remove(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewCourseInformation");
        }

        public IActionResult AddClassInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveClasses([Bind(" Class, CourseCode, Id")]Classes classes)
        {
            using (var db = _context)
            {

                var test = new Classes
                {
                    //ClassId = classes.ClassId,
                    Class = classes.Class,
                    CourseCode = classes.CourseCode,
                    Id = classes.Id
                   };

                db.Classes.Add(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewClassInformation");
        }

        public IActionResult ViewClassInformation()
        {
            var test = _context.Classes.ToList();
            ClassList classModel = new ClassList
            {
                ClassAll = test
            };

            return View(classModel);
        }

        [HttpPost]
        public IActionResult ViewClassInformation(int? Id)
        {
            var test = _context.Classes.Where(a => a.Class == Id).ToList();
            ClassList classModel = new ClassList
            {
                ClassAll = test
            };

            return View(classModel);
        }

        public IActionResult UpdateClassInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateClasses(int Id, [Bind("ClassId, Class, CourseCode, Id")]Classes classes)
        {
            using (var db = _context)
            {

                var test = new Classes
                {
                    ClassId = classes.ClassId,
                    Class = classes.Class,
                    CourseCode = classes.CourseCode,
                    Id = classes.Id
                };

                db.Classes.Update(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewClassInformation");
        }

        public IActionResult DeleteClassInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteClasses(int Id, [Bind("ClassId, Class, CourseCode, Id")]Classes classes)
        {
            using (var db = _context)
            {

                var test = new Classes
                {
                    ClassId = classes.ClassId,
                    Class = classes.Class,
                    CourseCode = classes.CourseCode,
                    Id = classes.Id
                };

                db.Classes.Remove(test);
                db.SaveChanges();
            }

            return RedirectToAction("ViewClassInformation");
        }

        public IActionResult PublishResult()
        {
            return View();
        }

        public IActionResult RegisterSearch()
        {
            return View();
        }
    }
}
