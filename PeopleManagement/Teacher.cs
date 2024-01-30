using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string HigherEducationInstitution { get; set; }

        public Teacher(string name, string surname, DateTime dateOfBirth, string higherEducationInstitution, string position, string department)
            : base(name, surname, dateOfBirth)
        {
            Position = position;
            Department = department;
            HigherEducationInstitution = higherEducationInstitution;
        }
        public override string ShowInfo()
        {
            return $"{Name} {Surname} {DateOfBirth.Date.ToString("yyyy/MM/dd")} {Position} {Department} {HigherEducationInstitution}";
        }
    }
}