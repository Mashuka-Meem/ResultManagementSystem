using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public int Roll { get; set; }
        public string Contact { get; set; }
    }

    public class StudentList
    {
        public List<Student> StudentAll { get; set; }
    }
}
