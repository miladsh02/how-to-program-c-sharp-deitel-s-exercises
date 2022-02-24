
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("please enter 3 double number\n-------------------");
        int i = 0;
        double[] number = new double [3];
        while (i<3)
        {
            Console.Write($"Number {i + 1:D2}: ");
            number[i] = double.Parse(Console.ReadLine());
            i++;
            Console.WriteLine("");
        }

        double total = 0;
        foreach (double element in number)
            total += element;
        Console.WriteLine($"Total is :{total:F2}");
    }//end of main
}