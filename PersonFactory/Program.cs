using System;

namespace PersonFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonFactory().CreatePerson("Alex");
            Console.WriteLine(person.Id);

            person = new PersonFactory().CreatePerson("Bill");
            Console.WriteLine(person.Id);
        }
    }

    public class Person
    {
        public static int CurrentId { get; set; } = 0; 
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    
    public class PersonFactory
    {
        public Person CreatePerson(string name) => new Person(Person.CurrentId++, name);
    }
}