using System;
using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
        //Display invoice
        var invoice = new[]     {new Invoice(83, "Electric sander", 7, 57.98),
                                 new Invoice(24, "Power saw", 18, 99.99),
                                 new Invoice(7, "Sledge hammer", 11, 21.50),
                                 new Invoice(77, "Hammer", 76, 11.99),
                                 new Invoice(39, "Lawn mower", 3,79.50),
                                 new Invoice(68, "Screwdriver", 106, 6.99),
                                 new Invoice(56, "Jig saw", 21, 11.00),
                                 new Invoice(3, "Wrench", 34, 7.50),};
            Console.WriteLine($"{"Part Number",-15}{"Part Description",-20}{"Quantity",-15}{"Price",-10}{"Total",-10}\n-------------------------------------------------------------------");
        foreach (var element in invoice)
            Console.WriteLine(element);


        //SortByPartDescription
        var SortByPartDescription =
            from filter in invoice
            orderby filter.PartDescription
            select filter;
        Console.WriteLine($"\n\nSort By Part Description\n-------------------------------------------------------------------");
        foreach (var element in SortByPartDescription)
            Console.WriteLine(element);


        //SortByPrice
        var SortByPrice =
            from filter in invoice
            orderby filter.Price
            select filter;
        Console.WriteLine($"\n\nSort By Part Price\n-------------------------------------------------------------------");
        foreach (var element in SortByPrice)
            Console.WriteLine(element);



        //PartDescription and Quantity and sort the Quantity
        var SortByQuantity =
            from filter in invoice
            orderby filter.Quantity
            select  filter;
        Console.WriteLine($"\n\nPartDescription and Quantity and sort the Quantity\n-------------------------------------------------------------------");
        foreach (var element in SortByQuantity)
        Console.WriteLine($"{element.PartDescription,-20}{element.Quantity,-5} "  );



        //PartDescription and Value and Invoice Total and sortby Value
        Console.WriteLine($"\n\nPartDescription and Value and Invoice Total and sortby Value\n-------------------------------------------------------------------");
        foreach (var element in SortByPrice)
            Console.WriteLine($"{element.PartDescription,-20}${element.Price,-10}${element.Total,-10:F2} ");

        //the InvoiceTotals in the range $200 to $500.
        var InvoiceTotalRange200To500 =
            from filter in invoice
            where filter.Total <= 500 && filter.Total >= 200
            orderby filter.Total
            select filter;
        Console.WriteLine($"\n\nthe InvoiceTotals in the range $200 to $500\n-------------------------------------------------------------------");
        foreach (var element in InvoiceTotalRange200To500)
            Console.WriteLine($"{element} ");




        Console.ReadKey();
    }
    }

using System;
using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
        //Display invoice
        var invoice = new[]     {new Invoice(83, "Electric sander", 7, 57.98),
                                 new Invoice(24, "Power saw", 18, 99.99),
                                 new Invoice(7, "Sledge hammer", 11, 21.50),
                                 new Invoice(77, "Hammer", 76, 11.99),
                                 new Invoice(39, "Lawn mower", 3,79.50),
                                 new Invoice(68, "Screwdriver", 106, 6.99),
                                 new Invoice(56, "Jig saw", 21, 11.00),
                                 new Invoice(3, "Wrench", 34, 7.50),};
            Console.WriteLine($"{"Part Number",-15}{"Part Description",-20}{"Quantity",-15}{"Price",-10}{"Total",-10}\n-------------------------------------------------------------------");
        foreach (var element in invoice)
            Console.WriteLine(element);


        //SortByPartDescription
        var SortByPartDescription =
            from filter in invoice
            orderby filter.PartDescription
            select filter;
        Console.WriteLine($"\n\nSort By Part Description\n-------------------------------------------------------------------");
        foreach (var element in SortByPartDescription)
            Console.WriteLine(element);


        //SortByPrice
        var SortByPrice =
            from filter in invoice
            orderby filter.Price
            select filter;
        Console.WriteLine($"\n\nSort By Part Price\n-------------------------------------------------------------------");
        foreach (var element in SortByPrice)
            Console.WriteLine(element);



        //PartDescription and Quantity and sort the Quantity
        var SortByQuantity =
            from filter in invoice
            orderby filter.Quantity
            select  filter;
        Console.WriteLine($"\n\nPartDescription and Quantity and sort the Quantity\n-------------------------------------------------------------------");
        foreach (var element in SortByQuantity)
        Console.WriteLine($"{element.PartDescription,-20}{element.Quantity,-5} "  );



        //PartDescription and Value and Invoice Total and sortby Value
        Console.WriteLine($"\n\nPartDescription and Value and Invoice Total and sortby Value\n-------------------------------------------------------------------");
        foreach (var element in SortByPrice)
            Console.WriteLine($"{element.PartDescription,-20}${element.Price,-10}${element.Total,-10:F2} ");

        //the InvoiceTotals in the range $200 to $500.
        var InvoiceTotalRange200To500 =
            from filter in invoice
            where filter.Total <= 500 && filter.Total >= 200
            orderby filter.Total
            select filter;
        Console.WriteLine($"\n\nthe InvoiceTotals in the range $200 to $500\n-------------------------------------------------------------------");
        foreach (var element in InvoiceTotalRange200To500)
            Console.WriteLine($"{element} ");




        Console.ReadKey();
    }
    }

