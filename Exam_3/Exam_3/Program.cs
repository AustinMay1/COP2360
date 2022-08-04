namespace Exam_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
                {
                new ElementarySchoolStudent("Samuel", "Clark", "123456"),
                new MiddleSchoolStudent("David", "Hunt", "654321"),
                new HighSchoolStudent("Mary", "Anderson", "321654"),
                new CollegeStudent("Tim", "Russell", "456123")
                };

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }
                                 
        }
    }
}