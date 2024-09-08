using P4C1.Interfaces;

namespace P4C1.Services
{
    public class Multiplication : IApplication
    {
        public void Run()
        {
            try
            {
                Console.Write("Please enter the number to generate its multiplication table: ");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} * {i} = {number * i}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
