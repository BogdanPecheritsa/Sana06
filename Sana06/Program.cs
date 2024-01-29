using PeopleManagement;
using System;

Person person = new Person("Petro", "Poroshenko", new DateTime(1965, 9, 26));
string personInfo = person.ShowInfo();
Console.WriteLine("---Person---");
Console.WriteLine(personInfo);