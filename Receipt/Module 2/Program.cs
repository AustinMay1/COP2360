namespace Module_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Receipt - Austin May - COP2360");
            Console.WriteLine("======================");
            Console.WriteLine("\nEnter the price of your items.");

            decimal apple;
            decimal orange;
            decimal banana;
            decimal watermelon;
            decimal grapes;
            decimal lemon;
            

            Console.Write("\nApple:  $");
            apple = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nOrange:  $");
            orange = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nBanana:  $");
            banana = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nWatermelon:  $");
            watermelon = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nGrapes:  $");
            grapes = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nLemon:  $");
            lemon = Convert.ToDecimal(Console.ReadLine());

            decimal subtotal = apple + orange + banana + watermelon + grapes + lemon;
            decimal tax = subtotal * 0.065m;
            decimal total = subtotal + tax;

            Console.WriteLine("\n======================");
            Console.WriteLine("Subtotal: ${0}", subtotal);
            Console.WriteLine("Tax: ${0}", tax);
            Console.WriteLine("Total: ${0}", total);
        }
    }
}