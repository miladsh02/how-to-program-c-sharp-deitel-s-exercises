using System;

namespace _8._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] sells;
            sells =  new int[5,3];
            for (int i = 0; i < sells.GetLength(0); i++)
                for (int j = 0; j < sells.GetLength(1); j++)
                    sells[i, j] = random.Next(100, 300);

            Console.WriteLine($"{"Market 1",20} {"Market 2",10} {"Market 3",10}");
            for (int i = 0; i < sells.GetLength(0); i++)
                Console.WriteLine($"product {i + 1}:{sells[i, 0],5}{sells[i, 1],11}{sells[i, 2],11}");

            int[] Sumantion = new int[3];
            for (int i = 0; i < Sumantion.Length; i++)
                for (int j = 0; j < sells.GetLength(0); j++)
                    Sumantion[i] += sells[j, i];
            Console.Write("Sumantion:");
            
                Console.Write($"{Sumantion[0],5}{Sumantion[1],11}{Sumantion[2],11}");
            int total = 0;
            foreach (int element in Sumantion)
                total += element;
            Console.WriteLine($"\n\nTotal:{total}");
        }
    }
}
