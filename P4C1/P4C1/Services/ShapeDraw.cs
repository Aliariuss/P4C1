using System;
using P4C1.Utilities;
using P4C1.Interfaces;

namespace P4C1.Services
{
    public class ShapeDrawing : IApplication
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Welcome to the Shape Drawing application...");
                Console.WriteLine("Press 1 to draw a square, 2 for a triangle, or 3 for a diamond shape.");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    DrawingShapes.DrawSquare();
                }
                else if (choice == 2)
                {
                    DrawingShapes.DrawTriangle();
                }
                else if (choice == 3)
                {
                    DrawingShapes.DrawDiamond();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
