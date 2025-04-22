namespace Notification { 

    delegate void Del (string Msg);
    class Notifier {
        
        public static void Not (string Msg, Del D) {
            D (Msg);
        }
    }
}