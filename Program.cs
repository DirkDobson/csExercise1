using System;

namespace csExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            // for ( int i = 0; i <= 100; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //        System.Console.WriteLine(i);
            //     }
            // }
            // System.Console.WriteLine("I will add all numbers until you type ok");
            // var num = 0;
            // var user = "";
            // var loop = true;
            // do {
            //     user = Console.ReadLine();
            //     if (user == "ok")
            //     {
            //     System.Console.WriteLine(num);
            //     loop = false;
            //     break;
            //     } 
            //     num += Convert.ToInt32(user);
            //     Console.WriteLine("total = " + num);
            //     continue;
            // }
            // while (loop == true);

            System.Console.WriteLine("I will find factoral of number you put");
            int fact = Convert.ToInt32(Console.ReadLine());
            int newFact = 1;
            if (fact >= 0)
            {
                for ( int i = 1; i <= fact; i++)
                {               
                    newFact *= i;
                    System.Console.WriteLine("i = " + i);
                    System.Console.WriteLine("newFact = " + newFact);
                }
                Console.WriteLine(fact + "! = " + newFact);
            } else 
            {
                for ( int u = -1; u >= fact; u--)
                {
                    newFact *= u;
                    System.Console.WriteLine("i = " + u);
                    System.Console.WriteLine("newFact = " + newFact);
                }
                Console.WriteLine(fact + "! = " + newFact);
            }
        }
    }
}
