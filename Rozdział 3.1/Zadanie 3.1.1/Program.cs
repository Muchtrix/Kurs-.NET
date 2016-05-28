using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._1._1 {
    class Program {
        static void Main(string[] args) {
            Complex a = new Complex(real: 1, imaginary: 1);
            Complex b = new Complex(real: 3, imaginary: 5);

            Console.WriteLine($"{a:w} + {b:w} = {a + b:w}");
            Console.WriteLine($"{a:d} - {b:d} = {a - b:d}");
            Console.WriteLine($"{a} * {b} = {a * b}");

            Console.ReadKey();
        }
    }
}
