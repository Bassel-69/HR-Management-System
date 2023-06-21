using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG204_HW
{
    public class Sales : Employee
    {
        //We created 2 properties eachone of them represnt it's name:
        public double SalesPercent { get; set; }
        public double RecivingPercent { get; set; }


        /* Creating a constructor for the Sales class which takes parameters and assign it to the properties above
           the Sales constructor inherits the parameters of the Employee constructor as well, using the "base" keyword
           and take it as parameters beside it's own parameters */
        public Sales(/*Sales constructor Parameters goes here*/double SalesPercent, double RecivingPercent,
            /*Employee Constructor parameters goes here*/string FirstName, string LastName, string FatherName, decimal NationalID, DateTime Birthdate,
            DateTime HireDate) : base(FirstName, LastName, FatherName, NationalID, Birthdate, HireDate)
        {
            this.SalesPercent = SalesPercent;   
            this.RecivingPercent = RecivingPercent;
        }

        //the block of code below declares a Method that calculates the Monthly salary for Sales employee
        public double SalesMonthlySalary(double SalesAmount, double CustomerRecivingAmount)
        {
            return(SalesAmount * SalesPercent / 100) + (CustomerRecivingAmount * RecivingPercent / 100);
        }

    }
}
