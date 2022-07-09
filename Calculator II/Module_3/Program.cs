namespace Module_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstOperand;
            double secondOperand;
            double result;
            string optr;

            Console.Write("Enter first operand: ");
            firstOperand = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second operand: ");
            secondOperand = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+ - * /): ");
            optr = Console.ReadLine();

            if (optr == "+")
            {
                Console.WriteLine("Result: {0} + {1} = {2}", firstOperand, secondOperand, result = firstOperand + secondOperand);
            }
            else if (optr == "-")
            {
                Console.WriteLine("Result: {0} - {1} = {2}", firstOperand, secondOperand, result = firstOperand - secondOperand);
            }
            else if (optr == "*")
            {
                Console.WriteLine("Result: {0} * {1} = {2}", firstOperand, secondOperand, result = firstOperand * secondOperand);
            }
            else if (optr == "/")
            {
                Console.WriteLine("Result: {0} - {1} = {2}", firstOperand, secondOperand, result = firstOperand / secondOperand);
            }
            else
            {
                Console.WriteLine("Invalid operator. No calcuations were made.");
            }
        }
    }
}
