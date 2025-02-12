using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagmentSystem
{
    /// <summary>
    /// HR Department class derived from Department class.
    /// </summary>
    class HRDepartment : Department, IDepartmentOperations
    {
        public string Name { get; set; }

        public HRDepartment()
        {

            Name = "HR Department";

        }

        public override string GetDepartmentDetails()
        {

            return "Handles employee relations and recruitment.";

        }

        public void Operate()
        {

            Console.WriteLine("Performing HR Operations.");

        }

    }
    
    
}
