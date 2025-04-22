// 3️⃣ Generic Transformer
// Create a generic delegate Transformer<T> that takes one parameter and returns a result.
// Write a method that accepts this delegate to transform a list of elements (e.g., convert integers to strings, strings to uppercase, etc.).

using System;
using Transformer;

class Program {
    static void Main (string [] args) {
        List <int> Numbers = new List <int> {1,2,3,4,5,6,7,8,9,10};
        List <string> Words = new List <string> {"aaa", "bbb", "ccc", "ddd", "iii",};

        List <string> ResultNumbers = ListTransform.Transforming (Numbers, (x) => x.ToString());
        List <string> ResultWords = ListTransform.Transforming (Words, (x) => x.ToUpper ());

        foreach (string ResultNumber in ResultNumbers) {
            Console.WriteLine (ResultNumber);
        }

        foreach (string ResultWord in ResultWords) {
            Console.WriteLine (ResultWord);
        }


    }
}