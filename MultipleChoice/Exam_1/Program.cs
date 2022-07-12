namespace Exam_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempt = 1;
            int score = 0;
            string answerOne;
            string answerTwo;
            string userChoice;

            while (attempt <= 2)
            {
                Console.Write("\nAttempt {0}", attempt);
                Console.Write("\n1. Where is the capital of the state of Florida?\n A. Orlando\n B. Tallahassee\n C. Miami\n D. Tampa\n Answer: ");
                answerOne = Console.ReadLine().ToUpper();

                switch (answerOne)
                {
                    case "A":
                        break;
                    case "B":
                        score += 50;
                        break;
                    case "C":
                        break;
                    case "D":
                        break;
                    default:
                        break;
                }

                Console.Write("\n2. Where is Walt Disney World Park located in Florida?\n A. Orlando\n B. Tallahassee\n C. Miami\n D. Tampa\n Answer: ");
                answerTwo = Console.ReadLine().ToUpper();

                switch (answerTwo)
                {
                    case "A":
                        score += 50;
                        break;
                    case "B":
                        break;
                    case "C":
                        break;
                    case "D":
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nScore: {0}", score);

                if (score < 100)
                {
                    Console.Write("\nWould you like to try again? (y / n): ");
                    userChoice = Console.ReadLine().ToUpper();

                    if (userChoice == "Y")
                    {
                        score = 0;
                        attempt++;

                    }
                    else if (userChoice == "N")
                    {
                        break;
                    }
                }
                else if (score == 100)
                {
                    break;
                }

            }
        }
    }
}