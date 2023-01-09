using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, what is your porcentage grade? ");
        int userPorcentageGrade = Console.Read();

        if (userPorcentageGrade >= 90)
        {
            Console.Write("You got A grade");
        }

        else if(userPorcentageGrade >= 80)
        {
            Console.Write("You got B grade");
        }

        else if(userPorcentageGrade >= 70)
        {
            Console.Write("You got C grade");
        }

        else if(userPorcentageGrade >= 60)
        {
            Console.Write("You got D grade");
        }
        
        else if(userPorcentageGrade < 60)
        {
            Console.Write("You got F grade");
        }

        else
        {
            Console.Write("This is a not valid porcentage.")
        }

    }
}

