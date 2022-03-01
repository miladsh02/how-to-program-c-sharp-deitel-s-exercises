using System;

namespace _01.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int n, x = 1;
            Console.Write("please enter n number for factorials: ");
             n= int.Parse(Console.ReadLine()); ;
            if (n != 0) {
                for (int i = 1; i <= n; i++)
                {
                    x = i * x;
                }//End for
                Console.Write("n!={0}!={1}", n, x);
            }//End if
            else
                Console.Write("n!={0}!=1", n);



        }       
    }
}