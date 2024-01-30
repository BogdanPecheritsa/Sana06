using PeopleManagement;

Person[] persons = new Person[5];
persons[0] = new Person("Petro", "Poroshenko", new DateTime(1965, 9, 26));
persons[1] = new Applicant("Viktor", "Yanukovich", new DateTime(1950, 7, 9), 131, 8, "Lyceum #2");
persons[2] = new Student("Viktor", "Yuschenko", new DateTime(1954, 2, 23), 190, 11, "Lyceum #2", 1, "IPZ-23-1",
"Software engineering", "Zhytomyr Polytechnic State University");
persons[3] = new Teacher("Oleg", "Lyashko", new DateTime(1972, 12, 3), "Zhytomyr Polytechnic State University", "Professor", "Computer Science");
persons[4] = new LibraryUser("Vitaliy", "Klitschko", new DateTime(1971, 7, 19), "252", new DateTime(2024, 1, 23), 250);

string personsInfo = "";
for (int i = 0; i < persons.Length; i++)
{
    personsInfo += persons[i].ShowInfo() + "\n";
}
Console.WriteLine(personsInfo);