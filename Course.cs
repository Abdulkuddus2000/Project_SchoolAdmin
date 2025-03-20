using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Course
    {
        public string Title;
        public List<Student> Students = new List<Student>();


        public static void ShowOverview(string Title, List<Student> students)
        {
            Console.WriteLine(Title);
            foreach(Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
