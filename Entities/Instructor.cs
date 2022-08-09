using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Entities
{
    internal class Instructor
    {
        public string name { get; set; }
        public List<Course> courses = new List<Course>();

        public Instructor(string name)
        {
            this.name = name;
        }
    }
}
