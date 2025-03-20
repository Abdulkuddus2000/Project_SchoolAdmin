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
            student1.Courses[0] = "Programmeren";
            student1.Courses[1] = "Databanken";

            Student student2 = new Student();
            student2.Birthday = new DateTime(2000, 6, 1);
            student2.Name = "Mieke Vermeulen";
            student2.StudentNumber = Student.StudentCounter;
            Student.StudentCounter++;
            student2.Courses[0] = "Communicatie";

            student1.ShowOverview();
        }
    }
}
