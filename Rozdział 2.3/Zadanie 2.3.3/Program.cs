using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._3._3 {
    class Program {
        static void Main(string[] args) {
            List<int> lista = new List<int>();
            for (int i = 0; i < 10; ++i) lista.Add(i);

            List<string> listaStr = lista.ConvertAll(x => x.ToString());
            List<int> parzyste = lista.FindAll(x => x % 2 == 0);
            parzyste.ForEach(x => Console.WriteLine($"Liczba parzysta: {x}"));
            Console.WriteLine($"Usunieto {lista.RemoveAll(x => parzyste.Contains(x))} elementow");
            lista.Sort((x, y) => y - x);
            foreach(int i in lista) {
                Console.Write($"{i}, ");
            }

            Console.ReadKey();
        }
    }
}
