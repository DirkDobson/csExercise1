using System;

namespace csExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                   System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("I will add all numbers until you type ok");
            var num = 0;
            var user = "";
            var loop = true;
            do {
                user = Console.ReadLine();
                if (user == "ok")
                {
                System.Console.WriteLine(num);
                loop = false;
                break;
                } 
                num += Convert.ToInt32(user);
                Console.WriteLine("total = " + num);
                continue;
            }
            while (loop == true);
            {
            System.Console.WriteLine("I will find factorial of number you put");
            int fact = Convert.ToInt32(Console.ReadLine());
            int newFact = 1;
            if (fact >= 0)
            {
                for ( int i = 1; i <= fact; i++)
                {               
                    newFact *= i;
                }
                Console.WriteLine(fact + "! = " + newFact);
            } else 
            {
                System.Console.WriteLine("No negative number can have a factorial");
            }            
            
            Console.WriteLine("Guess number between 1 and 10. 4 tries");
            Random guess = new Random();
            int cpGuess = guess.Next(1, 11);
            int tries = 4;
            while (tries != 0)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess != cpGuess)
                {
                System.Console.WriteLine("wrong");
                --tries;
                continue;
                } else
                {
                    System.Console.WriteLine("You got it right");
                    break;
                }
            } 

            System.Console.WriteLine("find max number of 5 numbers");
            int numLength = 5;
            var array = new int[numLength];
            for( int o = 1; o <= numLength; o++)
            {
                array[o - 1] = Convert.ToInt32(Console.ReadLine());
            }
            int total = array[0];
            for (int u = 1; u <= numLength; u++)
            {
                if ( array[u - 1] >= total)
                {
                    total = array[u - 1];
                }
            }
                System.Console.WriteLine("Max number is " + total);
            
            }
            
        }
    }
}   
    

