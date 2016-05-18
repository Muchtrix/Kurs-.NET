using System;

namespace Zadanie_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100000; ++i)
            {
                int k = i;
                int suma = 0;
                while(k > 0)
                {
                    int a = k % 10;
                    if (a != 0 && (i % a) != 0) break;
                    suma += a;
                    k /= 10;
                }
                if (k == 0 && i % suma == 0) Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
