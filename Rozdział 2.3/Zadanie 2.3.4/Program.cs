using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._3._4 {
    class Program {
        static void Main(string[] args) {
            List<int> lista = new List<int>();
            for (int i = 0; i < 10; ++i) lista.Add(i);

            List<string> listaStr = ListHelper.ConvertAll(lista, x => x.ToString());
            List<int> parzyste = ListHelper.FindAll(lista, x => x % 2 == 0);
            ListHelper.ForEach(parzyste, x => Console.WriteLine($"Liczba parzysta: {x}"));
            Console.WriteLine($"Usunieto {ListHelper.RemoveAll(lista, x => parzyste.Contains(x))} elementow");
            ListHelper.Sort(lista, (x, y) => y - x);
            foreach (int i in lista) {
                Console.Write($"{i}, ");
            }

            Console.ReadKey();
        }

        public class ListHelper {
            public static List<TOutput> ConvertAll<T, TOutput>(List<T> list, Converter<T, TOutput> converter) {
                List<TOutput> wynik = new List<TOutput>();
                foreach(T elem in list) {
                    wynik.Add(converter(elem));
                }
                return wynik;
            }
            public static List<T> FindAll<T>(List<T> list, Predicate<T> match) {
                List<T> wynik = new List<T>();
                foreach(T elem in list) {
                    if (match(elem)) wynik.Add(elem);
                }
                return wynik;
            }
            public static void ForEach<T>(List<T> list, Action<T> action) {
                foreach(T elem in list) {
                    action(elem);
                }
            }
            public static int RemoveAll<T>(List<T> list, Predicate<T> match) {
                int licznik = 0, usunieto = 0;
                while(licznik < list.Count) {
                    if (match(list[licznik])) {
                        list.RemoveAt(licznik);
                        ++usunieto;
                    }
                    else ++licznik;
                }
                return usunieto;
            }
            public static void Sort<T>(List<T> list, Comparison<T> comparison) {
                for(int i = 0; i < list.Count; ++i) {
                    for(int j = i; j < list.Count - 1; ++j) {
                        if(comparison(list[j], list[j + 1]) > 0) {
                            T tmp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = tmp;
                        }
                    }
                }
            }
        }
    }
}
