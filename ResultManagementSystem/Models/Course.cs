using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
    }
    
    public class CourseList
    {
        public List<Course> CourseAll { get; set; }
    }
}
