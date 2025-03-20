namespace SchoolAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Birthday = new DateTime(2000, 6, 1);
            student1.Name = "Said Aziz";
            student1.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++; // student aangemaakt, dus verhogen

            // courses zijn private gemaakt, nu zijn ze niet meer accessible
            //student1.courses[0] = "Programmeren";
            //student1.courses[1] = "Databanken";
            student1.RegisterForCourse("Programmeren");
            student1.RegisterForCourse("Databanken");


            Student student2 = new Student();
            student2.Birthday = new DateTime(2000, 6, 1);
            student2.Name = "Mieke Vermeulen";
            student2.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;

            //student2.courses[0] = "Communicatie";
            student2.RegisterForCourse("Communicatie");

            Console.WriteLine(student1.GenerateNameCard());
            Console.WriteLine(student2.GenerateNameCard());

            Console.WriteLine(student1.DetermineWorkLoad());
            Console.WriteLine(student2.DetermineWorkLoad());
        }
    }
}