//Arrays; Introduction to Exception Handling (Exercises 8.10)
using System;

namespace _8._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] workers;
            workers = new int[10, 2];

            //Randomize the workers 
            Random RandomHour = new Random();
            for (int i = 0; i < 10; i++)
                workers[i, 0] = RandomHour.Next(30,65);
            //Show the time work and incomes
            ShowWorkTimeAndIncomes(ref workers);
            //chart
            Console.WriteLine("------------------------------");
            Chart(workers);

            Console.ReadKey();
        }
        //output chart
        static void Chart (int [,] Workers)
        {
            for(int i=0; i <= 7; i++)
            {
                int min = 200 + i * 10;
                int max = 200 + i * 10 + 9;
                Console.Write($"${200 + i * 10}-${200 + i * 10+9} : ");
                for (int star = 0; star < Workers.GetLength(0); star++)
                    if (Workers[star, 1] >= min & Workers[star, 1] <= max)
                        Console.Write("*");
                    
                    
                    else
                        Console.Write("");

                Console.WriteLine();
            }
            Console.Write("$280 and over:");
            for (int j = 0; j < Workers.GetLength(0); j++)
                if (Workers[j, 1] >= 280)
                    Console.Write("*");
            else
                    Console.Write("");

        }


        //Show the time work and incomes function
        static void ShowWorkTimeAndIncomes(ref int[,] workers)
        {
            Console.WriteLine($"{"Worker Name"}{"Time Work",20}{"Income",20} ");
            for(int i = 0; i < workers.GetLength(0); i++)
            {
                Console.Write($"Worker Number {i+1:D2} :");
                Console.Write($"{workers[i, 0],6:D2}");
                if (workers[i, 0] <= 48)
                {
                    workers[i, 1] = 200;
                    Console.WriteLine($"{workers[i, 1],24}");
                }
                else
                {
                    workers[i, 1]=200 + (5 * (workers[i, 0] - 48));
                    Console.WriteLine($"{workers[i, 1],24}");

                }

            }
        }
    }
}
