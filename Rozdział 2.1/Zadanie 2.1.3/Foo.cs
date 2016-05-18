using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._1._3
{
    class Foo
    {
        private int _licznik = 0;
        private int licznik {
            get {
                return _licznik++;
            }
        }

        private int _pub = 0;
        public int Pub {
            get {
                return _pub++;
            }
        }

        public Foo() { }

        public Foo(int i) { _licznik = i; }
    }
}
