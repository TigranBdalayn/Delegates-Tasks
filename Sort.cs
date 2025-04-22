namespace Lambda {

    class Person {

        public string Name { get; set; }
        public int Age {get; set;}

        public Person (string name, int age) {
            Name = name;
            Age = age;
        }   
    }

    class PersonAgeComparer : IComparer <Person> {
        
        public int Compare (Person a, Person b) {
            return a.Age.CompareTo (b.Age);
        }
    }

    class PersonNameComparer : IComparer <Person> {

        public int Compare (Person a, Person b) {
            return a.Name.CompareTo (b.Name);
        }
    }
}