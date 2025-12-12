using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            connected courseOps = new connected();
            courseOps.DisplayAllCourses();

            ///////////////////////////////////////////////////2222222


            //connected studentOps = new connected();
            //Console.Write("Enter Full Name: ");
            //string fullName = Console.ReadLine();
            //Console.Write("Enter Email: ");
            //string email = Console.ReadLine();
            //Console.Write("Enter Department: ");
            //string department = Console.ReadLine();
            //Console.Write("Enter Year of Study: ");
            //int yearOfStudy = int.Parse(Console.ReadLine());
            //studentOps.AddNewStudent(fullName, email, department, yearOfStudy);

            ////////////////////////////////////////33333333333333
            //courseOps.ByDepartment();

            //////////////////////////////44444
            //Console.Write("Enter Student ID: ");
            //int studentId = int.Parse(Console.ReadLine());
            //courseOps.DisplayEnrolledCoureses(studentId);

            /////////////////555
            //connected conn = new connected();

            //Console.Write("Enter Enrollment ID: ");
            //int enrollmentId = int.Parse(Console.ReadLine());

            //Console.Write("Enter Grade (A/B/C/D/F): ");
            //string grade = Console.ReadLine().ToUpper();           
            //if (grade != "A" && grade != "B" && grade != "C" && grade != "D" && grade != "F")
            //{
            //    Console.WriteLine("Invalid grade! Please enter A, B, C, D, or F.");
            //}
            //else
            //{
            //    conn.UpdateGrade(enrollmentId, grade);
            //}

            


            Console.ReadLine();


        }
    }
}
