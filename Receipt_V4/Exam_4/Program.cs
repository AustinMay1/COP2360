using System.Text.RegularExpressions;

namespace Exam_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = new string[100];
            float[] price = new float[100];
            int[] quantity = new int[100];
            var regex1 = @"^[a-zA-Z0-9 _()-.+]*$";
            var regex2 = @"^[0-9]*$";
            var regex3 = @"^[0-9.]*$";
            int count = -1, number;
            string input;
            float priceNo, subtotal = 0;


            while (true)
            {
                Console.Write("Item name(enter 0 to stop): ");
                input = Console.ReadLine();

                Match match = Regex.Match(input, regex1, RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry,Try again:");
                }
            }

            do
            {
                count++;
                items[count] = input;
                while (true)
                {
                    Console.Write("Item price: $");
                    input = Console.ReadLine();
                    Match match = Regex.Match(input, regex3, RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry,Try again:");
                    }
                }
                priceNo = float.Parse(input);
                price[count] = priceNo;

                while (true)
                {
                    Console.Write("Item Quantity: ");
                    input = Console.ReadLine();
                    Match match = Regex.Match(input, regex2, RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry,Try again:");
                    }
                }
                int.TryParse(input, out number);
                quantity[count] = number;
                subtotal += price[count] * quantity[count];
                Console.Write("Item name(enter 0 to stop): ");
                input = Console.ReadLine();

            } while (!input.Equals("0"));

            Console.WriteLine();
            Console.WriteLine("Item\tPrice\tQuantity\tSub Total");

            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(items[i] + "\t" + price[i] + "\t\t" + quantity[i] + "\t\t\t" + (price[i] * quantity[i]));
            }

            Console.WriteLine();
            Console.WriteLine("Receipt v4");        
            Console.WriteLine("====================================");
                    
            Console.WriteLine("Subtotal: $" + subtotal);
                    
            Console.WriteLine("Tax: $" + subtotal * 0.065);
                   
            Console.WriteLine("Total: $" + (subtotal + (subtotal * 0.065)));
                    
            
        
        }
    }
}