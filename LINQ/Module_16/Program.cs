namespace Module_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> customer = new List<string>();

            string firstName;
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            customer.Add(firstName);

            string lastName;
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            customer.Add(lastName);

            string street;
            Console.Write("Enter street: ");
            street = Console.ReadLine();
            customer.Add(street);

            string city;
            Console.Write("Enter city: ");
            city = Console.ReadLine();
            customer.Add(city);

            string state;
            Console.Write("Enter state: ");
            state = Console.ReadLine();
            customer.Add(state);

            string zip;
            Console.Write("Enter zip: ");
            zip = Console.ReadLine();
            customer.Add(zip);

            Console.WriteLine("\nCustomers information:\n");

            foreach (var word in customer)
            {
                Console.WriteLine(UppercaseWords(word.ToLower()));
            }

            static string UppercaseWords(string value)
            {
                char[] array = value.ToCharArray();

                if (array.Length >= 1)
                {
                    if (char.IsLower(array[0]))
                    {
                        array[0] = char.ToUpper(array[0]);
                    }
                }

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] == ' ')
                    {
                        if (char.IsLower(array[i]))
                        {
                            array[i] = char.ToUpper(array[i]);
                        }
                    }
                }
                return new string(array);
            }

        }
    }
}