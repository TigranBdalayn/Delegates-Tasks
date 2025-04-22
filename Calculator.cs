namespace Calculator {
    delegate int Del (int a, int b);
    class Cal {

        public static void Calculating (int a, int b, Del D ) {
            Console.WriteLine ("\nResoult:" + D(a,b));
        }
    }
}