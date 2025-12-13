using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Assessment
{
    internal class program2
    {
        static void Main(string[] args)
        {
            // Disconnected obj = new Disconnected();
            //Console.Write("Enter Course Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter Credits: ");
            //int credits = int.Parse(Console.ReadLine());

            //Console.Write("Enter Semester: ");
            //string sem = Console.ReadLine();

            //obj.InsertNewCourse(name, credits, sem);


            ////////////////////////////////////////////////////////////////////////4

            //Console.Write("Enter Student ID to delete: ");
            //int id = int.Parse(Console.ReadLine());

            //obj.DelStudent(id);
            ////////////////////////////////////////2
            //obj.UpdateCredits();

            ////////////////////////////////////////////////
            storedprocedure obj = new storedprocedure();
            Console.Write("Enter Semester: ");
            string sem = Console.ReadLine();
            obj.GetCoursesBySemester(sem);

            Console.WriteLine("Done!");


        }

    }
}

