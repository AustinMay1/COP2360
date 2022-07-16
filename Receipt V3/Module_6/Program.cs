namespace Module_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] items = new string[100, 4];
            int i, j, count = 0;
            double subTotal = 0, total;

            do
            {
                for (i = 0; i < 100; i++)
                {
                    Console.Write("Enter Item Name: ");
                    items[i, 0] = Console.ReadLine();

                    if (items[i, 0] == "0")
                    {
                        break;
                    }
                    else
                    {
                        count++;
                    }

                    Console.Write("Enter Item Price: $");
                    items[i, 1] = Console.ReadLine();

                    Console.Write("Enter Item Quantity: ");
                    items[i, 2] = Console.ReadLine();

                    subTotal += Convert.ToDouble(items[i, 1]) * Convert.ToDouble(items[i, 2]);

                    items[i, 3] = (Convert.ToDouble(items[i, 1]) * Convert.ToDouble(items[i, 2])).ToString();

                }

            } while (items[i,0] != "0");

            total = subTotal;

            Console.WriteLine();
            Console.WriteLine("Item      Price         Qty        Subtotal");
            Console.WriteLine("===========================================");

            for (i = 0; i < count; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(items[i, j] + "         ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===========================================");
            Console.WriteLine("Total Items: {0}", count);
            Console.WriteLine("Subtotal: ${0}", subTotal);
            Console.WriteLine("Total: ${0}", total);
        }



    }
    }
