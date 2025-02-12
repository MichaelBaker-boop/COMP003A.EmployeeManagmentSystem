// Author: Michael Baker
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP prinnciples in C#

using System.Reflection.Metadata.Ecma335;

namespace COMP003A.EmployeeManagmentSystem
{
    internal class Employee
    {

        // Fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        // Properties

        /// <summary>
        /// Gets the Employee ID.
        /// </summary>
        public string EmployeeId
        {

            get { return _employeeId; } // Read only property

        }

        /// <summary>
        /// Gets or sets the first name, and validates the input.
        /// </summary>
        public string FirstName
        {

            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(FirstName))
                {
                    throw new ArgumentNullException(nameof(FirstName));
                    Console.WriteLine("Name cannot be Null or Empty");
                }
                else
                {
                    _firstName = value;
                }

            }

        }

        /// <summary>
        /// Gets or sets the middle name, and validates the input.
        /// </summary>
        public string MiddleName
        {

            get { return _middleName; }
            set
            {
                if (MiddleName == null)
                {
                    throw new ArgumentNullException(nameof(MiddleName));
                    Console.WriteLine("Name cannot be Null.");
                }

                else
                {
                    _middleName = value;
                }

            }
        }

        /// <summary>
        /// Gets or sets the last name, and validates the input.
        /// </summary>
        public string LastName
        {

            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(LastName))
                {
                    throw new ArgumentNullException(nameof(LastName));
                    Console.WriteLine("Name cannot be Null or Empty.");
                }

                else
                {
                    _middleName = value;
                }

            }
        }

        /// <summary>
        /// Gets and sets salary amount, making sure the value is not less than 0.
        /// </summary>
        public double Salary
        {

            get { return _salary; }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Salary must be greater than 0.");
                }

            }

        }

        /// <summary>
        /// Contructor for Employee
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="FirstName"></param>
        /// <param name="MiddleName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        public Employee(string EmployeeID, string FirstName, string LastName, double Salary, string MiddleName = "")
        {

            _employeeId = EmployeeID;
            _firstName = FirstName;
            _middleName = MiddleName;
            _lastName = LastName;
            _salary = Salary;

        }

        /// <summary>
        /// Method for displaying full name of employee.
        /// </summary>
        public void PrintFullName()
        {

            if (_middleName == "")
            {
                Console.WriteLine($"{_firstName} {_lastName}");
            }
            else
            {
                Console.WriteLine($"{_firstName} {_middleName} {_lastName}");
            }

        }

        public void DisplayEmployeeInfo()
        {

            PrintFullName();
            Console.WriteLine($"Salary: {_salary}");

        }
    }

    /// <summary>
    /// Abstract class for department blueprints.
    /// </summary>
    abstract class Department
    {
        
         // Auto-implemented property
         public string DepartmentName {  get; set; }


         public abstract void GetDepartmentDetails();

         public void DisplayDepartmentInfo() 
         {

            Console.WriteLine($"{DepartmentName}");
            
         }
            
        
    }

    /// <summary>
    /// HR Department class derived from Department class.
    /// </summary>
    class HRDepartment : Department
    {
        public string Name { get; set; }

        public HRDepartment()
        {

            Name = "HR Department";

        }

        public override void GetDepartmentDetails()
        {

            Console.WriteLine($"Handles employee relations and recruitment.");

        }

    }

    /// <summary>
    /// IT Department class derived from Department class.
    /// </summary>
    class ITDepartment : Department
    {
        public string Name { get; set; }

        public ITDepartment()
        {

            Name = "IT Department";

        }

        public override void GetDepartmentDetails()
        {

            Console.WriteLine($"Manages technical resources and infrastructure.");

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
