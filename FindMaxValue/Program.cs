using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to Find maximum number Application.");
            Console.WriteLine("\nPlease choose number as shown below to find maximum value");
            Console.WriteLine("\n1:Find maximum value for integer inputs\n2:Find maximum value for float inputs\n3:Find maximum value for string inputs\n4:Find maximum value among similar type of values");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter the three Integer value in below line.");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    int maxInt = FindMaximumValue.FindMaxValue(a, b, c);
                    if (maxInt != 0)
                        Console.WriteLine("{0} is the maximum value out of {1} {2} {3}", FindMaximumValue.FindMaxValue(a, b, c), a, b, c);
                    break;
                case 2:
                    Console.WriteLine("\nEnter the three Float value in below line.");
                    float d = Convert.ToSingle(Console.ReadLine());
                    float e = Convert.ToSingle(Console.ReadLine());
                    float f = Convert.ToSingle(Console.ReadLine());
                    float maxFloat = FindMaximumValue.FindMaxValue(d, e, f);
                    if (maxFloat != 0)
                        Console.WriteLine("{0} is the maximum value out of {1} {2} {3}", FindMaximumValue.FindMaxValue(d, e, f), d, e, f);
                    break;
                case 3:
                    Console.WriteLine("\nEnter the three string value in below line.");
                    string g = Console.ReadLine();
                    string h = Console.ReadLine();
                    string i = Console.ReadLine();
                    string maxString = FindMaximumValue.FindMaxValue(g, h, i);
                    if (maxString != null)
                        Console.WriteLine("{0} is the maximum value out of {1} {2} {3}", FindMaximumValue.FindMaxValue(g, h, i), g, h, i);
                    break;
                case 4:
                    Console.WriteLine("Finding maximum value using Generic class");
                    int[] arrInt = { 20, 30, 10, 50, 40,30 };
                    GenericForFindMax<int> obj1 = new GenericForFindMax<int>(arrInt);
                    obj1.PrintMaximumValue();

                    double[] arrDouble = { 20.65, 32.06, 11.65, 25.2, 40.43, 56.8 };
                    GenericForFindMax<double> obj2 = new GenericForFindMax<double>(arrDouble);
                    obj2.PrintMaximumValue();

                    string[] arrString = { "Neha", "Payal", "Vicky", "Swagat" };
                    GenericForFindMax<string> obj3 = new GenericForFindMax<string>(arrString);
                    obj3.PrintMaximumValue();
                    break;
            }
            Console.ReadLine();
        }

    }
}
