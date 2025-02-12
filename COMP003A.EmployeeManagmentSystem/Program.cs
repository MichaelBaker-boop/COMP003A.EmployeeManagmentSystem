// Author: Michael Baker
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP prinnciples in C#

using System.Reflection.Metadata.Ecma335;

namespace COMP003A.EmployeeManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("", "", "", 1 , "");

            try
            {
                Console.WriteLine("Enter Employee ID: ");
                employee.EmployeeId = Console.ReadLine();
            }
            catch (Exception e) 
            {

                Console.WriteLine(e.Message);

            }




            Console.WriteLine("Enter First Name: ");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Middle Name (Press Enter to skip): ");
            employee.MiddleName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Enter Salary: \n");
            employee.Salary = double.Parse(Console.ReadLine());

            employee.DisplayEmployeeInfo();

            HRDepartment hRDepartment = new HRDepartment();
            Console.WriteLine($"Details: {hRDepartment.GetDepartmentDetails}\n");
            ((IDepartmentOperations)hRDepartment).Operate();

            ITDepartment iTDepartment = new ITDepartment();
            Console.WriteLine($"Details: {iTDepartment.GetDepartmentDetails}\n");
            ((IDepartmentOperations)(iTDepartment)).Operate();
            

        }
    }
}
