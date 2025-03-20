using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Student
    {
        public string Name;
        public DateTime Birthday;
        public string[] Courses = new string[5];
        public uint StudentNumber;
        public static uint StudentCounter;
        // static want, gaat niet over maar 1 student, wel over de klasse Student
        // als je alle instanties van een klasse nodig hebt, gebruik dan static


        public byte DetermineWorkLoad()
        {
            return 1;
        }

        public double Average()
        {
            return 1.1;
        }

        public string GenerateNameCard()
        {
            return "";
        }

        public void Quote(byte CourseIndex, byte score)
        {

        }

        public void RegisterForCourse(string courseName)
        {
            
        }

        public void ShowOverview()
        {
            DateTime now = DateTime.Now;
            TimeSpan age = now - Birthday;
            Console.WriteLine($"{Name}, {age} jaar");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport:");
            Console.WriteLine("**********\r\n");
            for (int i = 0; i < Courses.Length; i++)
            {
                for (int j = 0; j < CourseResults.Length; j++)
                {
                    Console.WriteLine($"{Courses[i]}\t\t{CourseResults[j]}");
                }
            }
        }

        public void DemonstrateStudent()
        {
            
        }

    }
}
