using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement
{
    public class LibraryUser : Person
    {
        public string LibraryCardNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int MonthlyLibraryFee { get; set; }

        public LibraryUser(string name, string surname, DateTime dateOfBirth, string libraryCardNumber, DateTime dateOfIssue,
            int monthlyLibraryFee) : base(name, surname, dateOfBirth)
        {
            LibraryCardNumber = libraryCardNumber;
            DateOfIssue = dateOfIssue;
            MonthlyLibraryFee = monthlyLibraryFee;
        }
        public override string ShowInfo()
        {
            return $"{Name} {Surname} {DateOfBirth.Date.ToString("yyyy/MM/dd")} {LibraryCardNumber} {DateOfIssue.Date.ToString("yyyy/MM/dd")} {MonthlyLibraryFee}";
        }
    }
}