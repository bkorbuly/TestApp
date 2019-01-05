using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace TestApp
{
    public class Program
    {
        readonly static Stopwatch time;
        static Program()
        {
            time = Stopwatch.StartNew();
        }

        static void Main(string[] args)
        {
            
            int x = 7;
            string text = "tail";
            text = "semperfi".ToUpper();
            x = 7 + 11;
            Console.WriteLine(x);
            Console.WriteLine(text);
            Console.WriteLine(time.Elapsed);
            Thread.Sleep(10000);
            Console.WriteLine(time.Elapsed);
            Console.ReadLine();

            CheckPrimeNumber();
            Console.ReadLine();         
        }

        public static List<int> CheckPrimeNumber()
        {
            double divisonHalf;
            bool prim = true;

            List<int> primList = new List<int>()
            {
                1,
                2,
            };

            for (int i = 3; i < 100; i++)
            {
                divisonHalf = i / 2;
                divisonHalf = Math.Round(divisonHalf) + 1;
                while( divisonHalf >= 2 && prim)
                {
                    if (i % divisonHalf == 0)
                    {
                        prim = !prim;
                    }
                    divisonHalf--;
                }
                if (prim)
                {
                    primList.Add(i);
                }
                prim = true;
            }

            primList.ForEach(Console.WriteLine);
            return primList;
        }
    }
}
