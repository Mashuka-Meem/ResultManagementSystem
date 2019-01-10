using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Classes
    {   
        [Key]
        public int ClassId { get; set; }
        public int Class { get; set; }
        public int CourseCode { get; set; }
        public int Id { get; set; }
    }

    public class ClassList
    {
        public List<Classes> ClassAll { get; set; }
    }
}
