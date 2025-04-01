using System.Net.Security;
using System.Security.Cryptography;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        int Bestnum = 7;
        Console.WriteLine ("My favorite Number is " + Bestnum);
        double Doublebest = 7.7D;
        Console.WriteLine ("An even cooler version of my favorite number is " + Doublebest);
        float Floatybest = 7.77F;
        Console.WriteLine ("A kind of cooler version of my favorite number is " + Floatybest);
        char Myconst = 'E';
        Console.WriteLine ("The First letter in my name is " + Myconst);
        bool Mybooly = false;
        Console.WriteLine ("Is pineapple good on pizza? " + Mybooly);
        string mystringy = "Kachow";
        Console.WriteLine ("Lightning Mcqueens catchphrase is "+ mystringy);
        // Part 2
        double myDouble = 9.78;
        int myInt = (int) myDouble;
        Console.WriteLine ("Double: " + myDouble);
        Console.WriteLine ("Int: " + myInt);
        
        string MyString = "Hello out there!";
        int myInt2 = 5;
        Console.WriteLine (Convert.ToString(myInt2));
        Console.WriteLine (Convert.ToString (Mybooly));
        //Part 3
        Console.WriteLine ("Enter Username:");
        string username = Console.ReadLine();
        Console.WriteLine ("Username is "+ username);
        Console.WriteLine ("Enter your age:");
        string age = Console.ReadLine();
        Console.WriteLine ("Your name and age is " + username + " " + Convert.ToInt32(age));
        //Part 4
        int num1 = 4;
        int num2 = 7;
        int sum1 = num1 + num2;
        Console.WriteLine (sum1 + " plus 10 is "+ (sum1+10));
        Console.WriteLine (sum1 + " minus 2 is "+ (sum1-2));
        Console.WriteLine (sum1 + " divided by 2 is "+ (sum1/2));
        Console.WriteLine (sum1 + " modulus of 2 is "+ (sum1%2));
        Console.WriteLine (sum1 + " times 3 is "+ (sum1*3));
        //Part 5
        float bleh = 1.123456789F;
        double bleh2 = 1.123456789D;
        Console.WriteLine (bleh);
        Console.WriteLine (bleh2);
    } 
}