// See https://aka.ms/new-console-template for more information
using SOA4;
List<Parent> people = new List<Parent>();
people.Add(new Parent("Zzzzzzzzzzzzzzzzzzzzzz"));
people.Add(new Child("eeeaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
people.Add(new Parent("aa"));
foreach (Parent p in people)
    p.PrintMessage();