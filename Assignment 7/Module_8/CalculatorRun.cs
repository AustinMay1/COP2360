
namespace Module_8
{
    internal class CalculatorRun
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.Write("Enter first operand: ");
            calculator.FirstOperand = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second operand: ");
            calculator.SecondOperand = Convert.ToDouble(Console.ReadLine());

            calculator.Addition();

            Console.WriteLine("Result: {0} + {1} = {2}",calculator.FirstOperand, calculator.SecondOperand, calculator.Result);
        }
    }
}

