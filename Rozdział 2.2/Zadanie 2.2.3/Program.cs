using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._2._3 {
    class Program {
        [DllImport(@"C:\Users\Wiktor\OneDrive\Studia\2015-16 Letni\Kurs .NET\Rozdział 2.2\Debug\BibliotekaDLL.dll", EntryPoint = "ExecuteC")]
        public static extern int ExecuteC(int x, del f);

        static void Main(string[] args) {
            if (args.Length > 0) {
                foreach (string arg in args) {
                    int i;
                    if (int.TryParse(arg, out i)) {
                        Console.WriteLine($"{i} jest pierwsza: {((ExecuteC(i, IsPrimeCs) == 1) ? "tak" : "nie") }");
                    }
                }
            }
        }

        public static int IsPrimeCs(int x) {
            for (int c = 2; c <= x - 1; c++) {
                if (x % c == 0) {
                    return 0;
                }
            }
            return (x>=2)? 1: 0;
        }

        public delegate int del(int i);
    }
}
