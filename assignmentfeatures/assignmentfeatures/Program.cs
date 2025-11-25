using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace assignmentfeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeDataReader reader = new MockEmployeeDataReader();
            PayrollProcessor payroll = new PayrollProcessor(reader);

            int[] employeeIds = { 101, 102, 103, 200 };

            foreach (int id in employeeIds)
            {
                decimal totalComp = payroll.CalculateTotalCompensation(id);
                Console.WriteLine($"Employee {id} Total Compensation: {totalComp:C}");
            }

            Console.ReadLine();
        }
    }
}