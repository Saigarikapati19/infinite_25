using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Assessment
{
    internal class Disconnected
    {
        public void InsertNewCourse(string courseName, int credits, string semester)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;Database=Archi;Server=(localdb)\\MSSQLLocalDB");

            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from courses", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "Courses");

                DataRow row = ds.Tables["Courses"].NewRow();
                row["CourseName"] = courseName;
                row["Credits"] = credits;
                row["Semester"] = semester;


                ds.Tables["Courses"].Rows.Add(row);
                da.Update(ds, "Courses");

                Console.WriteLine("Course inserted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void DelStudent(int studentId)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;Database=Archi;Server=(localdb)\\MSSQLLocalDB");

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Students", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();

                da.Fill(ds, "Students");

                DataTable dt = ds.Tables["Students"];
                DataRow rowToDelete = dt.Rows.Find(studentId);

                if (rowToDelete != null)
                {
                    rowToDelete.Delete();
                    da.Update(ds, "Students");
                    Console.WriteLine("Student deleted successfully!");
                }
                else
                {
                    Console.WriteLine("No student found with this ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void UpdateCredits()
        {
            SqlDataAdapter ad = null;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection("Integrated Security=true;Database=Archi;Server=(localdb)\\MSSQLLocalDB");

            try
            {
                con.Open();
                ad = new SqlDataAdapter("select * from courses", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(ad);
                ad.Fill(ds, "Courses");

                Console.Write("Enter CourseId to update credits: ");
                int courseId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Credits: ");
                int newCredits = Convert.ToInt32(Console.ReadLine());

                DataTable table = ds.Tables["Courses"];
                DataRow[] rows = table.Select($"CourseId = {courseId}");
                if (rows.Length > 0)
                {
                    rows[0]["Credits"] = newCredits;
                    ad.Update(ds, "Courses");
                    Console.WriteLine("Credits updated successfully");
                }
                else
                {
                    Console.WriteLine("Course not found");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}



