using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._1._2 {
    class Program {
        static void Main(string[] args) {
            Set a = new Set();
            a.Add(1);
            a.Add(2);
            a.Add(1);

            foreach (int i in a) Console.WriteLine($"{i}");

            Console.ReadKey();
        }
    }
}
