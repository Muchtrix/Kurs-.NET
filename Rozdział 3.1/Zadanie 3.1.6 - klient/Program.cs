using System;
using System.Runtime.Serialization.Formatters.Soap;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Net.Sockets;
using System.Threading;
using Zadanie_3._1._6___dll;

namespace Zadanie_3._1._6___klient {
    class Program {
        static void Main(string[] args) {
            while (true) {
                Person os = new Person { Name = "AAA", Surname = "BBBB" };
                Console.WriteLine("Podaj imię:");
                os.Name = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko:");
                os.Surname = Console.ReadLine();
                SoapFormatter format = new SoapFormatter();

                TcpClient klient = null;

                try {
                    klient = new TcpClient("localhost", 3020);
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Połączono do serwera.");
                var stream = klient.GetStream();

                Console.WriteLine($"Wysyłam obiekt person: {os.Name} {os.Surname}");
                format.Serialize(stream, os);

            }
            
        }

        
    }
}
