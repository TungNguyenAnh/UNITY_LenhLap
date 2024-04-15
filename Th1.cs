int choice;

System.Console.WriteLine("menu");
System.Console.WriteLine("draw the triangles");
System.Console.WriteLine("draw the squares");
System.Console.WriteLine("Draw the rectangle");
System.Console.WriteLine("Exit");
System.Console.WriteLine("Enter your choice:");

choice = Int32.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Draw the triangle");
        Console.WriteLine("******");
        Console.WriteLine("*****");
        Console.WriteLine("****");
        Console.WriteLine("***");
        Console.WriteLine("**");
        Console.WriteLine("*");
        break;
    case 2:
        Console.WriteLine("Draw the square");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        break;
    case 3:
        Console.WriteLine("Draw the rectangle");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        break;
    case 0:
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("No choice!");
        break;
}

while (choice != 0)
{

}         