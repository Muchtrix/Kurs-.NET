using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Zadanie_3._1._10 {
    class Program {
        static void Main(string[] args) {
            foreach (var a in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                Console.WriteLine(a);

            Console.WriteLine(Reader.GetResource("test"));

            Console.ReadKey();
        }

        class Reader {
            public static string GetResource(string name) {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string resName = $"Zadanie_3._1._10.{name}.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resName)) 
                    using (StreamReader reader = new StreamReader(stream)) {
                        return reader.ReadToEnd();
                    }
            }
        }
        
    }
}
