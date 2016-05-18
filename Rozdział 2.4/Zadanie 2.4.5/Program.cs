using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._4._5 {
    class Program {
        static void Main(string[] args) {

            List<klient> Klienci = new List<klient>();
            List<konto> Konta = new List<konto>();

            using (var klienciReader = new StreamReader("klienci.txt")) {
                while(klienciReader.EndOfStream == false) {
                    string linijka = klienciReader.ReadLine();
                    var tmp = linijka.Split(',');
                    Klienci.Add(new klient { Imie = tmp[0], Nazwisko = tmp[1], PESEL = tmp[2] });
                }
            }

            using (var kontaReader = new StreamReader("konta.txt")) {
                while(kontaReader.EndOfStream == false) {
                    string linijka = kontaReader.ReadLine();
                    var tmp = linijka.Split(',');
                    Konta.Add(new konto { PESEL = tmp[0], NrKonta = tmp[1] });
                }
            }

            var baza = from a in Klienci
                       join b in Konta on a.PESEL equals b.PESEL
                       select new {
                           Imie = a.Imie,
                           Nazwisko = a.Nazwisko,
                           PESEL = a.PESEL,
                           NrKonta = b.NrKonta
                       };

            foreach(var x in baza) {
                Console.WriteLine("=========================");
                Console.WriteLine($"{x.Imie} {x.Nazwisko} \tPESEL: {x.PESEL}");
                Console.WriteLine($"Nr konta: {x.NrKonta}");
            }
        }

        struct klient {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string PESEL { get; set; }
        }

        struct konto {
            public string NrKonta { get; set; }
            public string PESEL { get; set; }

        }
    }
}
