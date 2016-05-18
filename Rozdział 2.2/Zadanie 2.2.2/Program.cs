using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._2._2 {
    class Program {
        [DllImport(@"C:\Users\Wiktor\OneDrive\Studia\2015-16 Letni\Kurs .NET\Rozdział 2.2\Debug\BibliotekaDLL.dll", EntryPoint = "IsPrimeC")]
        public static extern int IsPrimeC(int x); 

        static void Main(string[] args) {
            if(args.Length > 0) {
                foreach(string arg in args) {
                    int i;
                    if (int.TryParse(arg, out i)) {
                        Console.WriteLine($"{i} jest pierwsza: {((IsPrimeC(i) == 1)? "tak" : "nie" ) }");
                    }
                }
            }
        }
    }
}
