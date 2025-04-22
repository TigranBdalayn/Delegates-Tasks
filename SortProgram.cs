
// 5️⃣ Sorting with Lambda
// Given a list of Person objects with Name and Age properties, 
// use List.Sort and a lambda expression to sort the list:
// by age ascending,
// by name alphabetically.


using System;
using Lambda;

class Program {
    static void Main (string[] args) {

        List <Person> persons = new List<Person> {
            new Person ("Tigran", 26),
            new Person ("David", 19),
            new Person ("Harut", 7),
            new Person ("Albert", 35)
        };

        //persons.Sort (new PersonNameComparer());
        persons.Sort ((a, b) => a.Name.CompareTo (b.Name));

        foreach (Person person in  persons) {
            Console.WriteLine (person.Name);
        }
        //persons.Sort (new PersonAgeComparer ());
        persons.Sort ((a, b) => a.Age.CompareTo (b.Age));

        foreach (Person person in persons) {
        Console.WriteLine (person.Age);
        }
    }

}