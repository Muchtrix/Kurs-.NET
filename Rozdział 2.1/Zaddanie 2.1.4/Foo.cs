using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaddanie_2._1._4 {
    public class Foo {
        [Oznakowane]
        public int Bar() {
            return 1;
        }
        public int Qux() {
            return 2;
        }

        [Oznakowane]
        public int Bas() => 4;

        [Oznakowane]
        public int Basx(int x) => x + 4;
    }

    public class Oznakowane : Attribute { }
}
