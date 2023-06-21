using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG204_HW
{
    public class Administrative : Employee
    {
        //We created 4 properties eachone of them represnt it's name:
        public double MonthlySalary { get; set; }
        public double HourlyWage { get; set; }
        public double OvertimeWage { get; set; }


        /* Creating a constructor for the Administrative class which takes parameters and assign it to the properties above
           the Administrative constructor inherits the parameters of the Employee constructor as well, using the keyword "base"
           and take it as parameters beside it's own parameters */
        public Administrative(/*Administrative constructor parameters goes here*/double MonthlySalary, double HourlyWage, double OvertimeWage,
            /*Employee Constructor parameters goes here*/string FirstName, string LastName, string FatherName, decimal NationalID, DateTime Birthdate,
            DateTime HireDate) : base(FirstName, LastName, FatherName, NationalID, Birthdate, HireDate)
        {
            this.MonthlySalary = MonthlySalary;
            this.HourlyWage = HourlyWage;
            this.OvertimeWage = OvertimeWage;
        }


        //the block of code below declares a Method that calculates the Monthly salary for an employee
        public double CalculateMonthlySalary(double hoursWorked, double overtimeHours)
        {
            return MonthlySalary + (hoursWorked * HourlyWage) + (overtimeHours * OvertimeWage);
        }
    }
}
