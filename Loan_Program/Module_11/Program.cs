namespace Module_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Amount, Length, Rate;

            C1 c1 = new C1();

            Console.Write("Enter loan amount: $");
            Amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of loan in years: ");
            Length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter interest rate: %");
            Rate = Convert.ToDouble(Console.ReadLine());

            double loan = c1.PayInterests(Amount, Length, Rate);

            Console.WriteLine("Total interest: $" + loan);

            Message message = new Message();

            message.iMessage();
        }
    }
}