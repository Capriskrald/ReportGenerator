using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class ReportGeneratorSalaryFirst : ReportGenerator
    {
        public void CompileReport()
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }

            Console.WriteLine("Salary-first report");
            foreach (var e in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("------------------");
            }
        }
        }
    }
}
