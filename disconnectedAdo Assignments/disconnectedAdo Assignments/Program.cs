using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disconnectedAdo_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disconnected d = new Disconnected();
            //d.ShowDetails();
            //d.EmployeeFilter();
            //d.ShowTotalTables();
            //d.CopyDepartment();
            d.MergeTables();
            Console.ReadLine();
        }
    }
}
