using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._29__Multiplication_Table_of_a_Number_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Please enter a number: ");
            x = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
                Console.Write(x +"  *   "+i+"    =   "+i*x+"\n");
            Console.ReadKey();
        }
    }
}
