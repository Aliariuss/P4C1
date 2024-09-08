using P4C1.Interfaces;

namespace P4C1.Services
{
    public class Calculator : IApplication
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Welcome to the Calculator...");
                Console.WriteLine("---------------------------------------");

                Console.Write("Please enter the first number: ");
                float number1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Please enter the second number: ");
                float number2 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Please select an operation (*,/,+,-): ");
                string operation = Console.ReadLine();

                float result = operation switch
                {
                    "*" => number1 * number2,
                    "+" => number1 + number2,
                    "-" => number1 - number2,
                    "/" when number2 != 0 => number1 / number2,
                    "/" => throw new InvalidOperationException("Division by zero is not allowed."),
                    _ => throw new InvalidOperationException("Invalid operation.")
                };

                Console.WriteLine("The result of your calculation is: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
