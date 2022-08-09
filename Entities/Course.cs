using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Entities
{
    internal class Course
    {
        public string nameCurse { get; set; }

        public HashSet<Student> users = new HashSet<Student>();

        public Course(string nameCurse)
        {
            this.nameCurse = nameCurse;
        }

    }
}
