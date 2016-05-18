using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaCs
{
    [Guid("DBE0E8C4-1C61-41f3-B6A4-4E2F353D3D05")]
    public interface Interfejs {
        int IsPrime(int x);
    }

    [Guid("C6659361-1625-4746-931C-36014B146679")]
    public class PrimeTester : Interfejs {
        public int IsPrime(int x) {
            for (int c = 2; c <= x - 1; c++) {
                if (x % c == 0) {
                    return 0;
                }
            }
            return (x >= 2) ? 1 : 0;
        }
    }
}
