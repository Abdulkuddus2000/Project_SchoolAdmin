using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Student
    {
        public string Name;
        public DateTime Birthday;
        private string[] courses = new string[5];
        public uint StudentNumber;
        public static uint StudentCounter;
        // static want, gaat niet over maar 1 student, wel over de klasse Student
        // als je alle instanties van een klasse nodig hebt, gebruik dan static


        public double DetermineWorkLoad()
        {
            double total = 0.0;
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
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
        public void RegisterForCourse(string course)
        {
            // binnenin de klasse kan je wel aan de private-fields, buiten de klasse niet
            int freePlace = -1;
            // -1, om de lus te beëindigen
            for (int i = 0; i < courses.Length && freePlace == -1; i++)
            {
                if (this.courses[i] is null)
                {
                    freePlace = i;
                }
            }
            if(freePlace > -1)
            {
                courses[freePlace] = course;
            }
        }
    }
}
