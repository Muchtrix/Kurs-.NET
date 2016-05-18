using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._3._1 {
    class Program {
        static void Main(string[] args) {
            List<int> lista = new List<int>();
            ArrayList listaTab = new ArrayList();

            // Dodawanie elementów
            DateTime pocz = DateTime.Now;
            for(int i = 0; i < 1000000; ++i) {
                lista.Add(i);
            }
            DateTime koniec = DateTime.Now;
            Console.WriteLine($"Dodawanie do list<int>: {koniec - pocz}");

            pocz = DateTime.Now;
            for (int i = 0; i < 1000000; ++i) {
                listaTab.Add(i);
            }
            koniec = DateTime.Now;
            Console.WriteLine($"Dodawanie do arrayList: {koniec - pocz}");

            // Usuwanie elementów
            pocz = DateTime.Now;
            for (int i = 0; i < 10000; ++i) {
                lista.Remove(i);
            }
            koniec = DateTime.Now;
            Console.WriteLine($"Usuwanie z list<int>: {koniec - pocz}");

            pocz = DateTime.Now;
            for (int i = 0; i < 10000; ++i) {
                listaTab.Remove(i);
            }
            koniec = DateTime.Now;
            Console.WriteLine($"Usuwanie z arrayList: {koniec - pocz}");

            // Słownik vs. tablica haszująca
            Dictionary<string, int> slownik = new Dictionary<string, int>();
            Hashtable tablica = new Hashtable();

            // Dodawanie elementów
            pocz = DateTime.Now;
            for (int i = 0; i < 1000000; ++i) {
                slownik.Add(i.ToString(), i);
            }
            koniec = DateTime.Now;
            Console.WriteLine($"Dodawanie do dictionary<string, int>: {koniec - pocz}");

            pocz = DateTime.Now;
            for (int i = 0; i < 1000000; ++i) {
                tablica.Add(i.ToString(), i);
            }
            koniec = DateTime.Now;
            Console.WriteLine($"Dodawanie do hashTable: {koniec - pocz}");

            // Usuwanie elementów
            pocz = DateTime.Now;
            for (int i = 0; i < 10000; ++i) {
                slownik.Remove(i.ToString());
            }
            koniec = DateTime.Now;
            Console.WriteLine($"Usuwanie z dictionary<string, int>: {koniec - pocz}");

            pocz = DateTime.Now;
            for (int i = 0; i < 10000; ++i) {
                tablica.Remove(i.ToString());
            }
            koniec = DateTime.Now;
            Console.WriteLine($"Usuwanie z hashTable: {koniec - pocz}");

            Console.ReadKey();
        }
    }
}
