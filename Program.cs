using OnlineCourses.Entities;
using System;

namespace OnlineCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();
            HashSet<Student> all = new HashSet<Student>();
            Instructor instructor = new Instructor("Alex");
            List<Course> courses = new List<Course>();
            courses.Add(new Course("A"));
            courses.Add(new Course("B"));
            courses.Add(new Course("C"));
            instructor.courses = courses;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("How many students for course " + courses[i].nameCurse + "?: ");
                int num = int.Parse(Console.ReadLine());
                for (int f = 0; f < num; f++)
                {
                    int uniqueCode = int.Parse(Console.ReadLine());
                    students.Add(new Student(uniqueCode));
                }
                courses[i].users = students;
                all.UnionWith(students);

                

            }
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}