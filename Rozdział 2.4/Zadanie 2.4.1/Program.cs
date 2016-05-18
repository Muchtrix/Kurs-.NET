using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._4._1 {
    class Program {
        static void Main(string[] args) {
            foreach(string s in args) {
                Console.WriteLine($"Napis {s} {((s.IsPalindrome()) ? "" : "nie")} jest palindromem.");
            }
        }
    }

    static class StringHelper {
        public static bool IsPalindrome(this string napis) {
            napis = napis.ToLower();
            int a = 0, b = napis.Length - 1;
            while (a < b) {
                while (char.IsWhiteSpace(napis[a]) || char.IsPunctuation(napis[a])) ++a;
                while (char.IsWhiteSpace(napis[b]) || char.IsPunctuation(napis[b])) --b;
                if (napis[a] != napis[b]) return false;
                ++a; --b;
                }
            return true;
        }
    }
}
