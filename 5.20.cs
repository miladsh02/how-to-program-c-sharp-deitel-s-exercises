//5.20
using System;

namespace _5._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_price = 0,price;
            double payments;
            Console.Write("Please enter how many items you perchased : ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n+1; i++)
            {
                Console.Write("Please enter the price of item {0}: ", i);
                price = int.Parse(Console.ReadLine());
                total_price += price;

            }//End for
            Console.WriteLine("------------------------");
            if (total_price > 5000)
            {
                payments = total_price - total_price / 10;
                Console.WriteLine("Total perchased:{0}\nYou recived 10% discount so your final payments is : {1}", total_price, payments);
            }//End if
            else
            {
                Console.WriteLine("Total perchased:{0}\nfinal payments: {1}\n(If you perchased more than 5000$ you could recived 10% discound)", total_price, total_price);
            }//End else
            
        }//End main
    }//End Class
}//end namespace
