// 4️⃣ Predicate Filter
// Using Predicate<T> (a built-in generic delegate),
// write a method that filters elements in a list based on the predicate passed to it.
// Example: filter even numbers, or filter names starting with a specific letter.


using System;
using Predicate;

class Program {
    static void Main (string[] args) {

        List <int> Numbers = new List <int> {1,2,3,4,5,6,7,8,9,10};
        List <string> Words = new List <string> {"Asda","sfa", "dsfa", "sdsf", "fdg", "sda"};

        List <int> ResultNumbers =  Filter.Filtring (Numbers, (x) => x % 2 == 0);
        List <string> ResultWords = Filter.Filtring (Words, (x) => x[0] == 's');

        foreach (int Num in ResultNumbers) {
            Console.WriteLine (Num);
        }

        foreach (string ResultWord in ResultWords) {
            Console.WriteLine (ResultWord);
        }

    }
}
