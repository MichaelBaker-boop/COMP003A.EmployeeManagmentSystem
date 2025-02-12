using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagmentSystem
{
    /// <summary>
    /// IT Department class derived from Department class.
    /// </summary>
    class ITDepartment : Department, IDepartmentOperations
    {
        public string Name { get; set; }

        public ITDepartment()
        {

            Name = "IT Department";

        }

        public override string GetDepartmentDetails()
        {

            return "Manages technical resources and infrastructure.";

        }

        public void Operate()
        {

            Console.WriteLine("Performing IT Operations.");

        }
    }
    
    
}
