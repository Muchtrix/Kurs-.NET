using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._4._6 {
    class Program {
        static void Main(string[] args) {
            foreach (string s in args) {

                List<string> adresy = new List<string>();

                using (var reader = new StreamReader(s)) {
                    while (reader.EndOfStream == false) {
                        adresy.Add(reader.ReadLine().Split(' ')[1]);
                    }
                }

                var res = (from a in adresy
                           group a by a into b
                           orderby b.Count() descending
                           select new { IP = b.Key, Ile = b.Count() }).Take(3);

                Console.WriteLine($"Raport z pliku {s}:");
                foreach (var a in res) Console.WriteLine($"{a.IP} {a.Ile}");
            }
        }
    }
}
