using System;
using System.Linq;
using System.Collections.Generic; 

class Program
    {
        static void Main(string[] args)
        {
        var petName = new List<string>();
        int[] delete = new int[5];
        //initional delete with Number 1
        for (int i = 0; i < 5; i++)
            delete[i] = -1;
        //Take the name from user
        for (int i = 0; i < 5; i++) { 
            Console.Write($"Name {i+1:D2}:");
            string a= Console.ReadLine();
            petName.Add(a);}//end of for
        /* 
        //sort by characters number and display  

        var sortedByNumbers =
            from counter in petName
            orderby counter.Length
            select counter;
        //diplay ordered by number of characters
       
        foreach (var element in sortedByNumbers)
            Console.Write($"{element},");  
       */

        //find the same characters and removing it
        for (int i = 0; i < 4; i++) {
            for (int j = i + 1; j < 5; j++)
                if (petName[i] == petName[j])
                    delete[i] = i;
                else
                    continue;}//End of for loop

        for (int i = 4; i > -1; i--)
            if (delete[i] != -1)
                petName.RemoveAt(i);
            else
                continue;
        //Display The Final results
        Console.WriteLine($"------------------------------------------------------------\n");
        foreach (var element in petName)
            Console.Write($"{element},");
        Console.ReadKey();
    }//end of main
        
    }//end of Class
    

