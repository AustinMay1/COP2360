namespace Exam_2
{
    internal class PersonRun
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("Enter your name: ");
            person.Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            person.Age = Convert.ToInt16(Console.ReadLine());

            person.YTK();

            Console.WriteLine("{0}, you have {1} years left to work until you can retire.", person.Name, person.YearsToWork);
        }
    }
}