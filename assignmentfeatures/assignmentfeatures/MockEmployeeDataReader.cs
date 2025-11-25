using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentfeatures
{
    
        public class MockEmployeeDataReader : EmployeDataReader
        {
            public EmployeRecord GetEmployeeRecord(int employeeId)
            {
                switch (employeeId)
                {
                    case 101:
                        return new EmployeRecord { Id = 101, Name = "Mani", Role = "Developer", IsVeteran = false };
                    case 102:
                        return new EmployeRecord { Id = 102, Name = "Gari", Role = "Manager", IsVeteran = true };
                    case 103:
                        return new EmployeRecord { Id = 103, Name = "Vin", Role = "Intern", IsVeteran = false };
                    default:
                        return new EmployeRecord { Id = employeeId, Name = "Sai", Role = "Other", IsVeteran = false };
                }
            }
        }

    
}