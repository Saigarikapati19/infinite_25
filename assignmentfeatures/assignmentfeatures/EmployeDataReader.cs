using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentfeatures
{
    
        public interface EmployeDataReader
        {
            EmployeRecord GetEmployeeRecord(int employeeId);
        }
    
}
