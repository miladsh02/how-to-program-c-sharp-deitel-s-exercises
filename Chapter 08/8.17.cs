using System;

namespace _8._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int arraylength = 13;
            int[] frequence = new int[arraylength];
            int rol1, rol2;

            for(int i = 0; i < 36000; i++){
                rol1 = random.Next(1, 7);
                rol2 = random.Next(1, 7);
                ++frequence[rol1 + rol2];}


            Console.WriteLine($"{"Sum",0}{"Frequence",15}");
            for(int j = 0; j < 11; j++)
            Console.WriteLine($"{j + 2:D2}{frequence[j + 2],12}");
            
        }
    }
}
