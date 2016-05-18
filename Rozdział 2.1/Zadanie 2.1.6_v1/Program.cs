using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._1._6_v1 {
    class Program {
        static void Main(string[] args) {
            foo obj1 = new foo();
            sluchacz s = new sluchacz(obj1);

            for(int i = 1; i <= 10; ++i) {
                Console.WriteLine(obj1[i]);
            }

            Random gen = new Random();

            switch (gen.Next() % 3) {
                case 0:
                    obj1.przedstaw();
                    break;
                case 1:
                    Console.WriteLine(obj1.Licznik);
                    break;
            }

            Console.ReadKey();
        }
    }

    class foo {

        public int this[int x] => x* x; 

        int _licznik = 0;
        public int Licznik {
            get {
                zmianaStanu();
                return ++_licznik;
            }
        }

        public delegate void handler(object sender);

        public event handler zdarzenie;

        public string przedstaw() {
            return $"Hej, jestem {this.GetType()}";
        }

        void zmianaStanu() {
            if(zdarzenie != null) {
                zdarzenie(this);
            }
        }
    }

    class sluchacz {
        public sluchacz(foo x) {
            x.zdarzenie += wolaj;
        }

        void wolaj(object x) {
            Console.WriteLine($"Obiekt {x.GetType()} zmienił stan.");
        }
    }
}
