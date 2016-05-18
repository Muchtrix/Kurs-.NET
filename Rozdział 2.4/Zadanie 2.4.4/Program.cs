using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_2._4._4 {
    class Program {
        static void Main(string[] args) {
            if (args.Length == 0) args = new string[] { "."};
            
            foreach (string arg in args) {
                
                var folder = new DirectoryInfo(arg);
                var suma = (from a in folder.EnumerateFiles()
                            select a.Length).Aggregate((x, y)=> x + y);
                
                Console.WriteLine($"Suma długości plików w {((arg == ".")? "bieżącym katalogu":arg)} to {suma}");
            }
        }
    }
}
