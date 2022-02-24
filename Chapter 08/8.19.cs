using System;

namespace _8._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool[] CapacityClass1 = new bool[5];
            bool[] CapacityClass2 = new bool[5];
            for (int i = 0; i < CapacityClass1.Length; i++) {
                CapacityClass1[i] = Convert.ToBoolean(random.Next(0, 2));
                CapacityClass2[i] = Convert.ToBoolean(random.Next(0, 2)); }




            int a;
            bool b;
            Console.WriteLine("Hello choese your class A or B With 1 or 2 :");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                b=CheekClass(CapacityClass1);
                if (b == false)
                {
                    for(int j = 0; j < CapacityClass1.Length; j++)
                    {
                        if (CapacityClass1[j] == false)
                        {
                            CapacityClass1[j] = true;
                            Console.WriteLine($"In class A set Numbe{j+1} registered for you");
                        }

                    }
                }
                else
                {
                    b = CheekClass(CapacityClass2);
                    if (b == false)
                    {
                      Console.Write("Sorry Class A is full if you want register Class b put 2: ");
                        a = int.Parse(Console.ReadLine());
                        if (a == 2)
                        {
                            for (int j = 0; j < CapacityClass2.Length; j++)
                            {
                                if (CapacityClass2[j] == false)
                                {
                                    CapacityClass2[j] = true;
                                    Console.WriteLine($"In class B set Numbe{j+1} registered for you");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("The next flight will take another 3 hours ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The next flight will take another 3 hours ");
                    }
                    
                }

            }
            else if (a == 2)
            {
                b = CheekClass(CapacityClass2);
                if (b == false)
                {
                    for (int j = 0; j < CapacityClass2.Length; j++)
                    {
                        if (CapacityClass2[j] == false)
                        {
                            CapacityClass2[j] = true;
                            Console.WriteLine($"In class B set Numbe{j+1} registered for you");
                        }

                    }
                }

                else
                {
                    b = CheekClass(CapacityClass1);
                    if (b == false)
                    {
                        Console.Write("Sorry Class B is full if you want register Class A put 1: ");
                        a = int.Parse(Console.ReadLine());
                        if (a == 1)
                        {
                            for (int j = 0; j < CapacityClass1.Length; j++)
                            {
                                if (CapacityClass1[j] == false)
                                {
                                    CapacityClass1[j] = true;
                                    Console.WriteLine($"In class A set Numbe{j+1} registered for you");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("The next flight will take another 3 hours ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The next flight will take another 3 hours ");
                    }

                }
            }

            else
            Console.WriteLine("Please enter right value ");



            Console.ReadKey();
        }
        static bool CheekClass(bool [] Class)
        {
            bool a=true;
            for(int i = 0; i < Class.Length; i++)
            {
                if (Class[i] == false)
                {
                    a = false;
                    break;
                }

                else
                    a = true;
            }

            return (a);
        }
    }
}
