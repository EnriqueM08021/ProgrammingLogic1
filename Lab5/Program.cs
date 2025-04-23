namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

foreach (string season in seasons)
{
    Console.WriteLine(season);
}
//Part 2
string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.WriteLine("Enter a number from 1 to 7 to see the corresponding day:");

if (int.TryParse(Console.ReadLine(), out int dayNumber))
{
    if (dayNumber >= 1 && dayNumber <= 7)
    {
        Console.WriteLine($"The day corresponding to {dayNumber} is {days[dayNumber - 1]}.");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
//Part 3
string[] books = { "Harry Potter", "Percy Jackson", "Miss Peregrine's Home for Peculiar Children" };
string[] authors = { "J.K. Rowling", "Rick Riordan", "Ransom Riggs" };

if (books.Length == authors.Length)
{
    for (int i = 0; i < books.Length; i++)
    {
        Console.WriteLine($"{books[i]} by {authors[i]}");
    }
}
else
{
    Console.WriteLine("The number of books and authors do not match.");
}
//Part 4
int[] temperatures = { 65, 72, 78, 70, 68 };

Console.WriteLine("Temperatures in ascending order:");
Array.Sort(temperatures);
foreach (int temp in temperatures)
{
    Console.Write($"{temp} ");
}
Console.WriteLine();

int lowestTemperature = temperatures[0];
int highestTemperature = temperatures[temperatures.Length - 1];

Console.WriteLine($"Lowest Temperature: {lowestTemperature}");
Console.WriteLine($"Highest Temperature: {highestTemperature}");
//Part 5
int[] countdown = { 5, 4, 3, 2, 1 };

Console.WriteLine("Original order:");
foreach (int number in countdown)
{
    Console.Write($"{number} ");
}
Console.WriteLine();

Array.Reverse(countdown);

Console.WriteLine("Reversed order:");
for (int i = 0; i < countdown.Length; i++)
{
    Console.Write($"{countdown[i]} ");
}
Console.WriteLine();
    }
}
