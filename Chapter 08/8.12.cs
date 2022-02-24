using System;

namespace _8._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            Console.WriteLine("Hello ,Please enter 5 number between 1 and 1000 \n ------------------- ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                number[i] = int.Parse(Console.ReadLine());

                if (number[i] >= 1 && number[i] <= 1000)
                    continue;
                else{
                    Console.WriteLine("Your number isn't between 1 and 1000 ");
                    Environment.Exit(0);}//end of else
            }//end of for
            Console.WriteLine("\n-----------------");
            int j = 1;
            foreach(int element in number)
            {
                if (element >= 1 && element <= 1000)
                {
                    Console.WriteLine($"Number{j}: {element}");
                    j++;
                }
                    
                else
                {
                    j++;
                    continue;
                }
                    
            }

            Console.ReadKey();
        }//end of main
    }
}
