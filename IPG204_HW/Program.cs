using System;

namespace IPG204_HW
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of administrative employees:");//asking the user to enter the number of administrative employees
            int adminnumEmployees = int.Parse(Console.ReadLine());//taking the input and assign it to adminnumEmployees variable

            Administrative[] Adminemployees = new Administrative[adminnumEmployees]; //creating array instance from Administrative Class

            for (int i = 0; i < adminnumEmployees; i++) /* for loop to iterate trough the array for each object and
                                                    * take each employee information as input from the user*/
            {
                Console.WriteLine($"\nEnter information for employee {i + 1}:\n");

                Console.Write("First name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Father name: ");
                string fatherName = Console.ReadLine();

                Console.Write("National ID: ");
                decimal nationalID = decimal.Parse(Console.ReadLine());

                Console.Write("Birth date (MM/DD/YYY): ");
                DateTime birthdate = DateTime.Parse(Console.ReadLine());

                Console.Write("Hire date (MM/DD/YYY): ");
                DateTime hireDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Monthly salary: ");
                double monthlySalary = double.Parse(Console.ReadLine());

                Console.Write("Hourly wage: ");
                double hourlyWage = double.Parse(Console.ReadLine());

                Console.Write("Overtime wage: ");
                double overtimeWage = double.Parse(Console.ReadLine());

                Administrative employee = new Administrative(monthlySalary, hourlyWage, overtimeWage, firstName, lastName,
                    fatherName, nationalID, birthdate, hireDate); /*employee instance that represents the previous inputs*/

                Adminemployees[i] = employee;//we store each employee object from above in Adminemployees array
            }

            Console.WriteLine("\n========== Employee information stored successfully ==========\n");/*A message to confirm creating
                                                                                                     each object*/



            Console.WriteLine("Enter the number of Sales employees:");//asking the user to enter the number of sales employees
            int salesnumEmployees = int.Parse(Console.ReadLine());//taking the input and assign it to salesnumEmployees variable

            Sales[] Salesemployees = new Sales[salesnumEmployees]; //creating array instance from Sales Class

            for (int i = 0; i < salesnumEmployees; i++) /* for loop to iterate trough the array for each object and
                                                    * take each employee information as input from the user*/
            {
                Console.WriteLine($"\nEnter information for employee {i + 1}:\n");

                Console.Write("First name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Father name: ");
                string fatherName = Console.ReadLine();

                Console.Write("National ID: ");
                decimal nationalID = decimal.Parse(Console.ReadLine());

                Console.Write("Birth date (MM/DD/YYY): ");
                DateTime birthdate = DateTime.Parse(Console.ReadLine());

                Console.Write("Hire date (MM/DD/YYY): ");
                DateTime hireDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Sales Percent: %");
                double SalesPercent = double.Parse(Console.ReadLine());

                Console.Write("Recived amount percentage from costumers: %");
                double RecivingPercent = double.Parse(Console.ReadLine());



                Sales employee2 = new Sales(SalesPercent, RecivingPercent, firstName, lastName,
                    fatherName, nationalID, birthdate, hireDate); /*employee2 instance that represents the previous inputs*/

                Salesemployees[i] = employee2;//we store each employee object from above in Salesemployees array
            }

            Console.WriteLine("\n========== Employee information stored successfully ==========\n");/*A message to confirm creating
                                                                                                     each object*/









            bool x = true; /* we created a while loop to iterate through each option and perform its task */
            while (x == true)
            {

                Console.WriteLine("Select an Option to perform a task:\n"); //asking the user to choose an Option from the belows

                Console.WriteLine("1. View administrative employees information\n");
                Console.WriteLine("2. Calculate administrative employee monthly salary\n");
                Console.WriteLine("3. View sales employee information\n");
                Console.WriteLine("4. Calculate sales employees monthly salary\n");
                Console.WriteLine("5. Exit\n");


                int Option = int.Parse(Console.ReadLine()); //taking option as input
                switch (Option) // a switch to perform the task of each option
                {
                    case 1: //View administrative employees information
                        {
                               Console.Write("Enter employee number you want to display:  ");
                               int i = int.Parse(Console.ReadLine());
                            
                                Console.WriteLine($"\nEmployee {i} information:\n");
                                Console.WriteLine($"Name: {Adminemployees[i - 1].FirstName} {Adminemployees[i - 1].LastName}\n");
                                Console.WriteLine($"Father's Name: {Adminemployees[i - 1].FatherName} {Adminemployees[i - 1].LastName} \n");
                                Console.WriteLine($"National ID: {Adminemployees[i - 1].NationalID}\n");
                                Console.WriteLine($"Birthdate: {Adminemployees[i - 1].BirthDate.ToShortDateString()}\n");
                                Console.WriteLine($"Hire date: {Adminemployees[i - 1].HireDate.ToShortDateString()} \n");

                                Console.WriteLine("\n----------------------------------------------\n");
                            
                            break;
                        }

                    case 2: //Calculate administrative employee monthly salary
                        {
                                Console.Write("Enter employee number you want to display its salary:  ");
                                int i = int.Parse(Console.ReadLine());

                                Console.Write($"What is the daily Work Hours for the administrative employee {Adminemployees[i - 1].FirstName} " +
                                    $"{Adminemployees[i - 1].LastName} ? : ");

                                double WorkHours = double.Parse(Console.ReadLine());

                                Console.Write($"\nHow many Overtime Hours the administrative employee {Adminemployees[i - 1].FirstName} " +
                                    $"{Adminemployees[i - 1].LastName} did work? : ");
                                double overtimeHours = double.Parse(Console.ReadLine());

                                Console.WriteLine($"\nThe Monthly Salary for {Adminemployees[i - 1].FirstName} {Adminemployees[i - 1].LastName} " +
                                    $"is:  {Adminemployees[i - 1].CalculateMonthlySalary(WorkHours, overtimeHours)}");

                                Console.WriteLine("\n----------------------------------------------\n");
                            


                            break;
                        }

                    case 3:
                        {
                                Console.Write("Enter employee number you want to display:  ");
                                int i = int.Parse(Console.ReadLine());
                            
                                Console.WriteLine($"\nEmployee {i} information:\n");
                                Console.WriteLine($"Name: {Salesemployees[i - 1].FirstName} {Salesemployees[i - 1].LastName}\n");
                                Console.WriteLine($"Father's Name: {Salesemployees[i - 1].FatherName} {Salesemployees[i - 1].LastName} \n");
                                Console.WriteLine($"National ID: {Salesemployees[i - 1].NationalID}\n");
                                Console.WriteLine($"Birthdate: {Salesemployees[i - 1].BirthDate.ToShortDateString()}\n");
                                Console.WriteLine($"Hire date: {Salesemployees[i - 1].HireDate.ToShortDateString()} \n");

                                Console.WriteLine("\n----------------------------------------------\n");
                            
                            break;
                        }

                    case 4:
                        {
                                Console.Write("Enter employee number you want to display its salary:  ");
                                int i = int.Parse(Console.ReadLine());
                            
                                Console.Write($"What is the sales Amount of the sales employee {Salesemployees[i - 1].FirstName} " +
                                    $"{Salesemployees[i - 1].LastName}? : ");

                                double SalesPercentage = double.Parse(Console.ReadLine());

                                Console.Write($"\nWhat is the recived amount from customers of {Salesemployees[i - 1].FirstName} " +
                                    $"{Salesemployees[i - 1].LastName}? : ");
                                double RecivedPercentage = double.Parse(Console.ReadLine());

                                Console.WriteLine($"\nThe Monthly Salary for {Salesemployees[i - 1].FirstName} {Salesemployees[i - 1].LastName} " +
                                    $"is:  {Salesemployees[i - 1].SalesMonthlySalary(SalesPercentage, RecivedPercentage)}");

                                Console.WriteLine("\n----------------------------------------------\n");
                            
                            break;
                        }

                    case 5: //the condition of the while loop is no longer valid
                        {
                            x = false;
                            break;
                        }
                }
            }




        }
    }
}