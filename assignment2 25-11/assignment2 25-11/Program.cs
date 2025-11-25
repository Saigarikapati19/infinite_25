using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_25_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeDataReader reader = new MockEmployeeDataReader();
            PayrollProcessor payroll = new PayrollProcessor(reader);

            int[] employeeIds = { 101, 102, 103, 200 };

            foreach (var id in employeeIds)
            {
                payroll.ProcessPayroll(id);
            }

            Console.ReadLine();
        }
    }
}
