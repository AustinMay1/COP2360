namespace Module_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "John";
            s1.LastName = "Smith";
            s1.StudentID = 2560;

            Student s2 = new Student("Peter");

            Student s3 = new Student("Morgan", "Simmons");

            Student s4 = new Student("James", "Walters");

            Student s5 = new Student("Linda", "Scott", 1005);

            Console.WriteLine();
            Console.WriteLine("Total students: {0}", Student.Count);

            Console.WriteLine("\n======Student List======");
            Console.WriteLine("Student: " + s1.FirstName + " " + s1.LastName + " " + "ID: {0}", s1.StudentID);
            Console.WriteLine("Student: " + s2.FirstName + " " + s2.LastName + " " + "ID: {0}", s2.StudentID);
            Console.WriteLine("Student: " + s3.FirstName + " " + s3.LastName + " " + "ID: {0}", s3.StudentID);
            Console.WriteLine("Student: " + s4.FirstName + " " + s4.LastName + " " + "ID: {0}", s4.StudentID);
            Console.WriteLine("Student: " + s5.FirstName + " " + s5.LastName + " " + "ID: {0}", s5.StudentID);
        }
    }
}