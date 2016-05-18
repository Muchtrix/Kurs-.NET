using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zaddanie_2._3._4 {
    class Program {
        [ComImport, Guid("E436EBB3-524F-11CE-9F53-0020AF0BA770")]
        class BibliotekaPrimeLib { }

        interface IPrime {
            int IsPrime(int x);
        }


        static void Main(string[] args) {
            BibliotekaPrimeLib lib = new BibliotekaPrimeLib();
            IPrime p = (IPrime)lib;
            Console.WriteLine($"Liczba 5 jest pierwsza: {p.IsPrime(5)}");
            Console.ReadKey();
        }
    }
}
