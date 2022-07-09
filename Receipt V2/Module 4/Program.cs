namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal count = 1;
            decimal price;
            decimal subtotal = 0;
            decimal tax; ;
            decimal total;

            Console.WriteLine("Receipt V2 - COP2360 - Austin May");
            Console.WriteLine("=================================");
            Console.WriteLine();

            do
            {
                Console.Write("Item {0}", count + " " + "Enter price: $");
                count++;
                price = Convert.ToDecimal(Console.ReadLine());
                subtotal += price;
                tax = subtotal * 0.06M;
                total = subtotal + tax + 1;

            }
            while (price != -1);

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Number of items: {0}", count - 2);
            Console.WriteLine("Subtotal: ${0}", subtotal + 1);
            Console.WriteLine("Tax: ${0}", tax + 0.1M);
            Console.WriteLine("Total: ${0}", total + 0.1M);

            
           
        }
    }
}