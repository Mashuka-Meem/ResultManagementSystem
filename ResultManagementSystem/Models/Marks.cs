using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Marks
    {
        public int Id { get; set; }
        public int Class{ get; set; }
        public int Roll { get; set; }
        public int CourseCode { get; set; }
        public string Exam { get; set; }
        public int Mark { get; set; }
    }

    public class MarksList
    {
        public List<Marks> MarksAll { get; set; }
    }
}
