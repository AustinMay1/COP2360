namespace Module_3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            double firstOperand;
            double secondOperand;
            double result;
            string oprt;

            Console.Write("Enter first operand: ");
            firstOperand = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second operand: ");
            secondOperand = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+ - / *): ");
            oprt = Console.ReadLine();

            switch (oprt)
            {
                case "+":
                    Console.WriteLine("Result: {0} + {1} = {2}", firstOperand, secondOperand, result = firstOperand + secondOperand);
                    break;
                case "-":
                    Console.WriteLine("Result: {0} - {1} = {2}", firstOperand, secondOperand, result = firstOperand - secondOperand);
                    break;
                case "*":
                    Console.WriteLine("Result: {0} * {1} = {2}", firstOperand, secondOperand, result = firstOperand * secondOperand);
                    break;
                case "/":
                    Console.WriteLine("Result: {0} / {1} = {2}", firstOperand, secondOperand, result = firstOperand / secondOperand);
                    break;
                default:
                    Console.WriteLine("Invalid operator. No calcuations made.");
                    break;
            }
        }
    }
}