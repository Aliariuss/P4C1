namespace P4C1.Utilities
{
    public static class DrawingShapes
    {
        public static void DrawSquare()
        {
            Console.Write("Please enter the side length: ");
            int sideLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void DrawTriangle()
        {
            Console.Write("Please enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void DrawDiamond()
        {
            Console.Write("Please enter the side length: ");
            int sideLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sideLength; i++)
            {
                for (int j = sideLength; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = sideLength - 1; i >= 1; i--)
            {
                for (int j = sideLength; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
