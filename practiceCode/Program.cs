// See https://aka.ms/new-console-template for more information
using practiceCode;

Person myPerson = new Person("Nancy", 120);
Person myOtherPerson = new Person("Richard");

Console.WriteLine(myPerson.name);
Console.WriteLine(myPerson.weight);
Console.WriteLine(myOtherPerson.name);
Console.WriteLine(myOtherPerson.weight);
Console.WriteLine(Person.personCount);
