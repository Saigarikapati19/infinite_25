using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment2_25_11.EmployeRecord;

namespace assignment2_25_11
{
    internal class EmployeDataReader
    {
        public static implicit operator EmployeDataReader(assignment2_25_11.MockEmployeeDataReader v)
        {
            throw new NotImplementedException();
        }

        public interface IEmployeeDataReader
        {
            EmployeeRecord GetEmployeeRecord(int employeeId);
        }


        public class MockEmployeeDataReader : IEmployeeDataReader
        {
            public EmployeeRecord GetEmployeeRecord(int employeeId)
            {
                switch(employeeId)
                {
                    case 101:
                        return new EmployeeRecord { Id = 101, Name = "Ashok", Role = "Developer", IsVeteran = false };
                    case 102:
                        return new EmployeeRecord { Id = 102, Name = "Kommuru", Role = "Manager", IsVeteran = true };
                    case 103:
                        return new EmployeeRecord { Id = 103, Name = "Avinash", Role = "Intern", IsVeteran = false };
                    default:
                        return new EmployeeRecord { Id = employeeId, Name = "Unknown", Role = "Other", IsVeteran = false };
                    }
                }
            }

        }
    }
