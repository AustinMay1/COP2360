namespace Module_5
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            double firstOperand;
            double secondOperand;
            string optr;

            Console.Write("Enter first operand: ");
            firstOperand = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+ - / *): ");
            optr = Console.ReadLine();

            Console.Write("Enter second operand: ");
            secondOperand = Convert.ToDouble(Console.ReadLine());

            

            switch (optr)
            {
                case "+":
                    Addition(firstOperand, secondOperand);
                    break;
                case "-":
                    Subtraction(firstOperand, secondOperand);
                    break;
                case "*":
                    Multipication(firstOperand, secondOperand);
                    break;
                case "/":
                    Division(firstOperand, secondOperand);
                    break;
                default:
                    Console.Write("Invalid operator, no calculations made.");
                    break;
            }
        }

        public static double Addition(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, sum);
            return sum;
        }

        public static double Subtraction(double x, double y)
        {
            double sum = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, sum);
            return sum;
        }

        public static double Division(double x, double y)
        {
            double sum = x / y;
            Console.WriteLine("{0} / {1} = {2}", x, y, sum);
            return sum;
        }

        public static double Multipication(double x, double y)
        {
            double sum = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, sum);
            return sum;
        }
    }
}