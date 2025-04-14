namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
    //Part 1
        for (int a = 0; a < 11; a++) 
            {
                Console.WriteLine(a);
            }
    //Part 2
        for (int b = 0; b < 21; b = b +2)
            {
                Console.WriteLine(b);
            }
    //Part 3
        int c =5;
        while (c>0)
        {
            Console.WriteLine(c);
            c--;
        }
    //Part 4
        int d;
        do
        {
            Console.Write("Enter a number greater than 100: ");
            string input = Console.ReadLine();
                if (int.TryParse(input, out d))
            {
                if (d > 100)
                {
                    Console.WriteLine("Correct Number: " + d);
                    break;
                }
                else
                {
                    Console.WriteLine("Number must be bigger than 100.");
                }
            }
        } while (true);
    //Part 4
    for (int e = 10; e < 1001; e = e +10)
            {
                Console.WriteLine(e);
            }
    //Part 5
 for (int f = 1; f <= 10; f++)
        {
            for (int g = 1; g <= f; g++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
    }
    }
}
