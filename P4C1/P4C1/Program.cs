using P4C1.Interfaces;
using P4C1.Services;

namespace P4C1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continueApp = true;

            while (continueApp)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Welcome! Please choose the application you want to use.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("1. Calculator");
                    Console.WriteLine("2. Multiplication Table");
                    Console.WriteLine("3. Number Guessing Game");
                    Console.WriteLine("4. Shape Drawing");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();

                    Console.Write("Please make your selection: ");
                    int selection = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    IApplication app = selection switch
                    {
                        1 => new Calculator(),
                        2 => new Multiplication(),
                        3 => new NumberGuessing(),
                        4 => new ShapeDrawing(),
                        5 => null,
                        _ => throw new InvalidOperationException("Invalid selection!")
                    };

                    if (app != null)
                    {
                        app.Run();
                    }
                    else
                    {
                        continueApp = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                if (continueApp)
                {
                    Console.WriteLine();
                    Console.Write("Would you like to continue? (Y/N): ");
                    string continueAnswer = Console.ReadLine().ToUpper();
                    continueApp = continueAnswer == "Y";
                }
            }
            Console.WriteLine("Program terminated.");
        }
    }
}
