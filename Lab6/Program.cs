namespace Lab6;

using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details. You can use this as an example for the other methods.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Part 1
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Part 2
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles.");
    }

    // Part 3
    public string GetDescription()
    {
        return $"{year} {color} {model}";
    }

    // Part 4
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"The car has been repainted to {newColor}.");
    }
}
    // Part 5
class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.model = "Subaru Crosstrek";
        myCar.color = "Blue";
        myCar.year = 2024;

        myCar.Display();
        Console.WriteLine();

        // Part 6
        myCar.Start();
        Console.WriteLine();

        // Part 7
        myCar.Drive(50);
        Console.WriteLine();

        // Part 8
        string description = myCar.GetDescription();
        Console.WriteLine(description);
        Console.WriteLine();

        // Part 9
        myCar.Repaint("red");
        Console.WriteLine($"The car has been repainted to {myCar.color}.");
    }
}