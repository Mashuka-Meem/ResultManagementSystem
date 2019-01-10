using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Contact { get; set; }
    }

    public class TeacherList
    {
        public List<Teacher> TeacherAll { get; set; }
    }   
}
