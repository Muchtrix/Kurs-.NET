using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using Zadanie_3._1._6___dll;

namespace Zadanie_3._1._6___Serwer {
    class Program {
        static void Main(string[] args) {
            TcpListener server = null;
            SoapFormatter format = new SoapFormatter();
            try {
                IPAddress adres = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(adres,3020);

                server.Start();
                while (true) {
                    Console.WriteLine("Czekam na połączenie... ");
                    TcpClient klient = server.AcceptTcpClient();
                    Console.WriteLine("Połączono!");
                    
                    NetworkStream stream = klient.GetStream();

                    Person a = (Person) format.Deserialize(stream);

                    Console.WriteLine($"Odebrałem obiekt Person: {a.Name} {a.Surname}");
                    
                    klient.Close();
                }
            }
            catch (SocketException e) {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally {
                server.Stop();
            }

            Console.Read();
        }

    }
}
