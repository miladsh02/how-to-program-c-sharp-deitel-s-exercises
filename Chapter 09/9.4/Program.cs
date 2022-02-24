using System;
using System.Collections.Generic;
using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
        var list = new List<string>();
        for(int i = 0; i < 3; i++)
        {string a = Console.ReadLine();
        list.Add(a);}
        var descendingSorted =
            from sort in list
            orderby sort descending
            select sort;
        Console.WriteLine("\n");
        Console.WriteLine("Descending Sorted:");
        foreach(var element in descendingSorted)
            Console.Write(element.ToUpper() + ", ");
        Console.WriteLine("\n--------------------------");



        var Sorted =
            from sort in list
            orderby sort descending
            select sort;
        Console.WriteLine("By Order Sorted:");
        foreach (var element in Sorted)
            Console.Write(element.ToUpper() + " ,");


        Console.ReadKey();
        }
    }

