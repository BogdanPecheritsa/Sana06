using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement
{
    public class LibraryUser : Person
    {
        public byte LibraryCardNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double MonthlyLibraryFee { get; set; }

        public LibraryUser(string name, string surname, DateTime dateOfBirth, byte libraryCardNumber, DateTime dateOfIssue,
            double monthlyLibraryFee) : base(name, surname, dateOfBirth)
        {
            LibraryCardNumber = libraryCardNumber;
            DateOfIssue = dateOfIssue;
            MonthlyLibraryFee = monthlyLibraryFee;
        }
    }
}