using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._4._7 {
    class Program {
        static void Main(string[] args) {
            var item = new { Field1 = "The value", Field2 = 5};
            var theList = new List<dynamic>();

            theList.Add(item);
            theList.Add(new { Field1 = "Other value", Field2 = 42 });

            foreach (dynamic a in theList) {
                Console.WriteLine($"{a.Field1}, {a.Field2}");
            }

            Console.ReadKey();
        }
    }
}
