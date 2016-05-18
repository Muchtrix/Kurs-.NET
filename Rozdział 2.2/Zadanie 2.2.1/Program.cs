using System;
using System.Runtime.InteropServices;

namespace Zadanie_2._2._1 {
    class Program {
        static int Main(string[] args) {
            byte[] str = new byte[256];
            Int32[] len = new Int32[1];
            len[0] = 256;
            GetUserName(str, len);

            return MessageBox((IntPtr)0, System.Text.Encoding.ASCII.GetString(str), "Nazwa użytkownika", 0);
        }


        [DllImport("Advapi32.dll", EntryPoint = "GetUserName", ExactSpelling = false, SetLastError = true)]
        static extern bool GetUserName([MarshalAs(UnmanagedType.LPArray)] byte[] lpBuffer, [MarshalAs(UnmanagedType.LPArray)] Int32[] nSize);

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);
    }
}
