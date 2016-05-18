using System;
using System.Reflection;

namespace Zadanie_2._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo obiekt = new Foo(164);
            int j = 0;
            var prywatnePola = obiekt.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            var prywatneWla = obiekt.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach(var p in prywatneWla) {
                Console.WriteLine($"Właściwość {p.Name}, wartość: {p.GetValue(obiekt)}");
            }

            foreach(var p in prywatnePola) {
                Console.WriteLine($"Pole {p.Name}, wartość: {p.GetValue(obiekt)}");
            }

            DateTime Start = DateTime.Now;
            for(int i = 0; i < 10000; ++i) {
                j += obiekt.Pub;
            }
            DateTime End = DateTime.Now;
            Console.WriteLine($"Dostęp bezpośredni: {(End - Start):ss\\.ffffff}s. Wynik {j}");

            j = 0;

            Start = DateTime.Now;
            for (int i = 0; i < 10000; ++i) {
                var wlas = obiekt.GetType().GetProperty("Pub");
                j += (int) wlas.GetValue(obiekt);
            }
            End = DateTime.Now;
            Console.WriteLine($"Dostęp przez refleksje: {(End - Start):ss\\.ffffff}s. Wynik {j}");


            Console.ReadKey();
        }
    }
}
