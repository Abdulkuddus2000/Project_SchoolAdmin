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


        public double DetermineWorkLoad()
        {
            double total = 0.0;
            for (int i = 0; i < Courses.Length; i++)
            {
                if (Courses[i] != null)
                {
                    total+=10;
                }
            }
            return total;

            // dit kan verschillen per student:
            // iemand die ingeschreven is voor meer vakken gaat minder null-waarden hebben
            // die zal ook een groter totaal aantal werkuren hebben
        }

        public double Average()
        {
            return 1.1;
        }

        public string GenerateNameCard()
        {
            return $"{this.Name} (STUDENT)";
        }

        public void Quote(byte CourseIndex, byte score)
        {

        }

        public void RegisterForCourse(string courseName)
        {
            
        }

        public void ShowOverview()
        {

        }

        public void DemonstrateStudent()
        {
            
        }

    }
}
