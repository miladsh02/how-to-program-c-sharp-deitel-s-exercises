using System;
using System.Collections.Generic;
using System.Text;

    class Invoice
    {
    public int PartNumber { get; }
    public string PartDescription { get; }
    public int Quantity { get; }
    public Double Price { get; }
    public Double Total { get; }

    public Invoice(int partNumber,String partDescription, int quantity, Double price)
    {
        PartNumber = partNumber;
        PartDescription = partDescription;
        Quantity = quantity;
        Price = price;
        Total = Price * Quantity;
    }
    public override string ToString() =>
        $"{PartNumber,-15}{PartDescription,-20}{Quantity,-15}${Price,-10}${Total,-10:F2}";
    }


