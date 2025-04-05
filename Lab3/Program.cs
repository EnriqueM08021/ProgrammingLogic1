namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine(a>b);
        Console.WriteLine(a<c);
        Console.WriteLine(a>b&&a>c);
        Console.WriteLine(a>b||a>c);
        //Part 2
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining&&haveUmbrella)
        {
            Console.WriteLine("Take an Umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }
        //Part 3
        Console.WriteLine("Enter age for ticket price:");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age<=4)
        {
            Console.WriteLine("Ticket is Free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child Ticket is $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard Ticket: $10");
        }
        else
        {
            Console.WriteLine("Senior Ticket: $6");
        }
        //Part 4
        int day = 8;
        switch (day) 
{
    case 1:
    Console.WriteLine("1-Monday");
    break;
    case 2:
    Console.WriteLine("2-Tuesday");
    break;
    case 3:
    Console.WriteLine("3-Wednesday");
    break;
    case 4:
    Console.WriteLine("4-Thursday");
    break;
    case 5:
    Console.WriteLine("5-Friday");
    break;
    case 6:
    Console.WriteLine("6-Saturday");
    break;
    case 7:
    Console.WriteLine("7-Sunday");
    break;
    default:
    Console.WriteLine("Invalid Day!");
    break;
}
    }
}
