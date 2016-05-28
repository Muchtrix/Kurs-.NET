using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_3._1._4 {
    class Program {
        static AutoResetEvent klientEvent = new AutoResetEvent(false);
        static ConcurrentQueue<Klient> klienci = new ConcurrentQueue<Klient>();


        static void Main(string[] args) {
            Random rand = new Random();

            new Thread(Golibroda.CutHair) { IsBackground = true, Name = "Golibroda" }.Start();

            Thread.Sleep(100);
            

            for (int i = 0; i < 20; i++) {
                Thread.Sleep(rand.Next(300, 2000));
                Klient c = new Klient() { Name = "Klient nr " + i };
                klienci.Enqueue(c);

                if (klienci.Count == 1) {
                    Klient.ObudzGolibrode();
                }
                else {
                    Console.WriteLine(c.Name + " czeka");
                }
            }
            Console.WriteLine("Koniec dnia");
            Console.ReadKey();
        }

        class Klient {
            public string Name { get; set; }

            public static void ObudzGolibrode() {
                klientEvent.Set();
            }
        }

        class Golibroda {
            public static void CutHair() {
                while (!klienci.IsEmpty) {
                    Klient c;
                    Thread.Sleep(1000);

                    if (klienci.TryDequeue(out c)) {
                        Console.WriteLine("Golibroda obsłużył: {0}", c.Name);
                    }
                }

                Console.WriteLine("Golibroda zasypia");
                GoToSleep();
            }

            private static void GoToSleep() {
                klientEvent.WaitOne();
                Console.WriteLine("Nowy klient!");

                CutHair();
            }
        }

    }
}
