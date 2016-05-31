using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.Timers;

namespace Zadanie_3._1._7 {
    class Program {
        static void Main(string[] args) {
            Timer time1 = new Timer(2000);
            time1.Elapsed += Sending;
            time1.Enabled = true;

            Timer time2 = new Timer(3000);
            time2.Elapsed += Recieving;

            Console.ReadKey();
        }

        private static void Recieving(object sender, ElapsedEventArgs e) {
            MessageQueue queue = new MessageQueue(@".\Private$\Kolejka");
            Message[] komunikaty = queue.GetAllMessages();
            foreach(Message k in komunikaty) {
                Console.Write(k.Body);
            }
        }

        private static void Sending(object sender, ElapsedEventArgs e) {
            MessageQueue queue = new MessageQueue(@".\Private$\Kolejka");
            queue.Label = "Kolejka komunikatów";
            for(int i = 0; i < 10; ++i) {
                queue.Send($"Wiadomość nr {i}");
            }
        }
    }
}
