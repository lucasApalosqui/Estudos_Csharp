using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Entities
{
    internal class Student
    {
        public int uniqueCode { get; private set; }

        public Student( int uniqueCode)
        {
            this.uniqueCode = uniqueCode;
        }

        public override int GetHashCode()
        {
            return uniqueCode.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return uniqueCode.Equals(other.uniqueCode);
        }
    }
}
