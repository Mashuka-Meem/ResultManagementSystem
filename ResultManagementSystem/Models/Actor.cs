using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorType { get; set; }
    }


    public class ActorList
    {
        public List<Actor> ActorAll { get; set; }
    }
}
