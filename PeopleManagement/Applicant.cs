using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement
{
    public class Applicant : Person
    {
        public byte ZnoPoints { get; set; }
        public byte EducationPoints { get; set; }
        public string EducationInstitutionName { get; set; }

        public Applicant(string name, string surname, DateTime dateOfBirth, byte znoPoints, byte educationPoints, string educationInstitutionName)
            : base(name, surname, dateOfBirth)
        {
            ZnoPoints = znoPoints;
            EducationPoints = educationPoints;
            EducationInstitutionName = educationInstitutionName;
        }
        public override string ShowInfo()
        {
            return $"{Name} {Surname} {DateOfBirth.Date.ToString("yyyy/MM/dd")} {ZnoPoints} {EducationPoints} {EducationInstitutionName}";
        }
    }
}