// 1️⃣ Basic Calculator with Delegates
// Write a program that defines a delegate Operation for arithmetic operations. 
// Create methods for Add, Subtract, Multiply, and Divide,
//  and assign them to the delegate to perform operations based on user input.

using System;
using Calculator;

class Program {
    static void Main (string[] args) {
        bool q = true;
        Del D = null;
        
        while (q) {

            Console.WriteLine ("\nPlease enter number operation number\n<< q >> for exit\n");
            int a = int.Parse (Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int b = int.Parse (Console.ReadLine ());
            operation = char.ToUpper(operation);

            switch (operation) {

                case '+':
                D = (a, b) => a + b;
                break;

                case '-':
                D = (a, b) => a - b;
                break;

                case '*':
                D = (a, b) => a * b;
                break;

                case '/':
                if (b == 0) {
                    Console.WriteLine ("You cannot divide by zero\n");
                    break;
                }
                D = (a, b) => a / b;
                break;

                case 'Q': 
                q = false;
                D = null;
                break;

                default:
                Console.WriteLine ("You have invalid argument\n");
                break;    
            }
            if (D == null) {
                break;
            }
            Cal.Calculating (a, b, D);
        }

    }
}