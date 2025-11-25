using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentfeatures
{
   
        internal class PayrollProcessor

        {

            private EmployeDataReader reader;





            private readonly EmployeDataReader _dataReader;

            private static readonly Dictionary<int, decimal> BaseSalaries = new Dictionary<int, decimal>

{

    {101, 65000m},

    {102, 120000m},

    {103, 30000m}

};

            public PayrollProcessor(EmployeDataReader dataReader)

            {

                _dataReader = dataReader;

            }

            public decimal CalculateTotalCompensation(int employeeId)

            {

                var record = _dataReader.GetEmployeeRecord(employeeId);

                decimal baseSalary = BaseSalaries.ContainsKey(employeeId) ? BaseSalaries[employeeId] : 0m;

                decimal bonus = 0m;

                switch (record.Role)

                {

                    case "Manager":

                        bonus = record.IsVeteran ? 10000m : 5000m;

                        break;

                    case "Developer":

                        bonus = 2000m;

                        break;

                    case "Intern":

                        bonus = 500m;

                        break;

                }

                return baseSalary + bonus;

            }


        }
    
}
