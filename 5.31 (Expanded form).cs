using System;

namespace _5._31__Expanded_form_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n = 0, a,b, c = 1, d;
            Console.Write("Please enter your number: ");
            x = int.Parse(Console.ReadLine());
            d = x;
            a = x;

            while (a != 0)
            {
                a /= 10;
                n++;
            }//End while

            for(int i = 1; i <= n; i++)
            {
                b = x % 10;

                if (i == 1)
                    c = 1;
                else
                    c = c * 10;

                Console.Write("({0}*{1})", b, c);
                if (i != n)
                    Console.Write("+");
                else
                    Console.Write("=");
                x = x / 10;

            }//End for

            Console.Write(d);

        }//End main
    }//End class
}//End namespace
