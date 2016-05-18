using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._4._3 {
    class Program {
        static void Main(string[] args) {
            foreach (string s in args) {
                using (var plik = File.Open(s, FileMode.Open)) {
                    using (var read = new StreamReader(plik)) {
                        Console.WriteLine($"Plik \"{s}\"");
                        var nazwiska = new List<string>();
                        while (read.EndOfStream == false) {
                            nazwiska.Add(read.ReadLine());
                        }

                        var litery = from x in nazwiska
                                     group x by x[0] into a
                                     orderby a.Key
                                     select a.Key;

                        Console.Write("[");
                        foreach (char a in litery) Console.Write($"{a}, ");
                        Console.WriteLine("]");             
                    }
                }
            }
        }
    }
}
