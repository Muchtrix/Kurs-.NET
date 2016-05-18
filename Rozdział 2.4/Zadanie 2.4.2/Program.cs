using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._4._2 {
    class Program {
        static void Main(string[] args) {
            foreach(string s in args) {
                using(var plik = File.Open(s, FileMode.Open)){
                    using (var read = new StreamReader(plik)) {
                        Console.WriteLine($"Plik \"{s}\"");
                        List<int> liczby = new List<int>();
                        while(read.EndOfStream == false) {
                            int tmp;
                            int.TryParse(read.ReadLine(), out tmp);
                            liczby.Add(tmp);
                        }

                        var a = from l in liczby
                                where l > 100
                                orderby l descending
                                select l;

                        var b = liczby.Where(i => i > 100).OrderByDescending(i => i);

                        Console.WriteLine("Wyrażenie LINQ:");
                        foreach (int l in a) Console.Write($"{l}, ");
                        Console.WriteLine("\nCiąg wywołań LINQ:");
                        foreach (int l in b) Console.Write($"{l}, ");
                    }
                }
            }
        }
    }
}
