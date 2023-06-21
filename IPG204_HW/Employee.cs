using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG204_HW
{
    public class Employee
    {
        //We created 4 properties eachone of them represnt it's name:
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public decimal NationalID { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        //Creating a constructor for the Employee class which takes parameters and assign it to the properties above
        public Employee(string FirstName, string LastName, string FatherName, decimal NationalID, DateTime Birthdate, DateTime HireDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FatherName = FatherName;
            this.NationalID = NationalID;
            this.BirthDate = Birthdate;
            this.HireDate = HireDate;
        }
    }
}
