using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement
{
    public class Student : Applicant
    {
        public byte Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string HigherEducationInstitution { get; set; }

        public Student(string name, string surname, DateTime dateOfBirth, byte znoPoints, byte educationPoints, string educationInstitutionName,
        byte course, string group, string faculty, string higherEducationInstitution) : base(name, surname, dateOfBirth, znoPoints,
            educationPoints, educationInstitutionName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            HigherEducationInstitution = higherEducationInstitution;
        }
        public override string ShowInfo()
        {
            return $"{Name} {Surname} {DateOfBirth.Date.ToString("yyyy/MM/dd")} {ZnoPoints} {EducationPoints} {EducationInstitutionName} " +
                $"{Course} {Group} {Faculty} {HigherEducationInstitution}";
        }
    }
}