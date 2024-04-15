using System;

class ShapePrinter
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            // Display the menu
            Console.WriteLine("\nShape Printer Menu:");
            Console.WriteLine("1. Print Rectangle");
            Console.WriteLine("2. Print Square Triangle");
            Console.WriteLine("3. Print Isosceles Triangle");
            Console.WriteLine("4. Exit");

            // Get user input
            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintRectangle();
                    break;
                case 2:
                    PrintSquareTriangle();
                    break;
                case 3:
                    PrintIsoscelesTriangle();
                    break;
                case 4:
                    isRunning = false;
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    static void PrintRectangle()
    {
        Console.Write("Enter the width of the rectangle: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter the height of the rectangle: ");
        int height = int.Parse(Console.ReadLine());

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void PrintSquareTriangle()
    {
        Console.Write("Enter the size of the square triangle: ");
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void PrintIsoscelesTriangle()
    {
        Console.Write("Enter the height of the isosceles triangle: ");
        int height = int.Parse(Console.ReadLine());

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < height - row - 1; col++)
            {
                Console.Write(" ");
            }

            for (int col = 0; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
