// Author: Michael Baker
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP prinnciples in C#

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
        public string EmployeeId
        {

            get { return _employeeId; } // Read only property

        }
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
        public string MiddleName
        {

            get { return _middleName; }
            set
            {
                if (string.IsNullOrEmpty(MiddleName))
                {
                    throw new ArgumentNullException(nameof(MiddleName));
                    Console.WriteLine("Name cannot be Null or Empty");
                }
                else
                {
                    _firstName = value;
                }

            }
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
