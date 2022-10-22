// See https://aka.ms/new-console-template for more information
using SOA4;
List<Person> people = new List<Person>();
people.Add(new Parent("Zzzzzzzzzzzzzzzzzzzzzz"));
people.Add(new Child("eeeaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
people.Add(new Parent("aa"));
foreach (Person p in people)
    p.Speak();