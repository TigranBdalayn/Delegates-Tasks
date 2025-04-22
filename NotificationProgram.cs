

using System;2️⃣ Notification System
Create a Notifier class that uses a delegate to send messages.
Allow the delegate to point to different message handlers (e.g., console output, file logger, or email simulation).
Example of console output : Console.WriteLine($"[Console]: {msg}")

using Notification;

class Program {
    static void Main (string[] args) {
        bool q = true;
        Del D = null;

        while (q) {
            Console.WriteLine ("\nPlease write a massage\n");
            string? Msg = Console.ReadLine ();
            Console.WriteLine ("Which direaction do you want to send?\n1: Console\n2: File\n3: Email:\n4: Exit");
            int? direaction = int.Parse (Console.ReadLine ());

            switch (direaction) {
                case 1:
                D = (x) => Console.WriteLine ($"[Console]: {x}\n");
                break;

                case 2:
                D = (x) => Console.WriteLine ($"[File]: {x}\n");
                break;

                case 3:
                D = (x) => Console.WriteLine ($"[Email]: {x}\n");
                break;

                case 4:
                q = false;
                D = null;
                break;

                default:
                Console.WriteLine ("Invalid argument,\nTry again");
                break;
            }

            if (D == null) {
                break;
            }

            Notifier.Not (Msg, D); 
        }
    }
}