using System;

namespace Zadanie_2._1._2 {
    class Program
    {
        static void Main(string[] args)
        {
            Grid siatka = new Grid(4, 5);

            for (int i = 0; i < 20; ++i) siatka[i % 4, i % 5] = i;

            for (int i = 0; i < 4; ++i)
            {
                int[] a = siatka[i];
                Console.Write("[");
                for (int j = 0; j < 5; ++j) Console.Write($"{a[j]}, ");
                Console.WriteLine("]");
            }
            Console.ReadKey();
        }
    }
}
