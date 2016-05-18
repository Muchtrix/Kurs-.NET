using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaddanie_2._1._4 {
    class Program {
        static void Main(string[] args) {
            Foo obiekt = new Foo();
            przegladnij(obiekt);

            Console.ReadKey();
        }

        static void przegladnij(object x) {
            Type typX = x.GetType();
            MethodInfo[] metody = typX.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var aaa = from a in metody
                      where a.ReturnType == typeof(int)
                      && a.GetParameters().Length == 0
                      && a.GetCustomAttributes(typeof(Oznakowane)).Count() > 0
                      select a;
            
            foreach(MethodInfo met in aaa) {
                Console.WriteLine($"Metoda: {met}: {met.Invoke(x, null)}");
            }
        }
    }
}
