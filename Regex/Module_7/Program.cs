using System.Text.RegularExpressions;

namespace Module_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string num;
            bool flag = false;

            Console.WriteLine("Enter the Name on Card (Letters only, first & last name): ");

            while(!flag)
            {
                name = Console.ReadLine();

                Match match = Regex.Match(name, @"\b[a-zA-Z]{2,15}\s[a-zA-Z]{2,15}\b", RegexOptions.IgnoreCase);

                flag = match.Success;

                if(!flag)
                {
                    Console.WriteLine("Enter Name on Card (Letters only, first & last name): ");
                }
            }

            flag = false;

            Console.WriteLine("Enter Credit Card Number (Digits Only): ");

            while(!flag)
            {
                num = Console.ReadLine();

                Match match = Regex.Match(num, @"^[0-9]{12,19}$", RegexOptions.IgnoreCase);

                flag = match.Success;

                if(!flag)
                {
                    Console.WriteLine("Enter Credit Card Number: (12 to 19 digits only): ");
                }
            }

            Console.WriteLine("Thank you for your order!");
        }
    }
}