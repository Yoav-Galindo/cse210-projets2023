using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome, What is your Grade Porcentage? ");

        string userPorcentage = Console.ReadLine();
        int percentage = int.Parse(userPorcentage);

        string letterGotIt = "";

        if (percentage >= 90)
        {
            letterGotIt = "You got 'A' ";
        }
        else if (percentage >= 80)
        {
            letterGotIt = "You got 'B' ";
        }
        else if (percentage >= 70)
        {
            letterGotIt = "You got 'C' ";
        }
        else if (percentage >= 60)
        {
            letterGotIt = "You got 'D' ";
        }
        else
        {
            letterGotIt = "You got 'F' ";
        }

        Console.WriteLine($"{letterGotIt} grade.");
        
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, You passed!");
        }
        else
        {
            Console.WriteLine("You have not passed!");
        }
    }
}