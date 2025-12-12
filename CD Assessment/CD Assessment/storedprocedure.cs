using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Assessment
{
    internal class storedprocedure
    {
        public void GetCoursesBySemester(string semester)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;Database=Archi;Server=(localdb)\\MSSQLLocalDB");

            try
            {
                con.Open();               
                SqlCommand cmd = new SqlCommand("usp_GetCoursesBySemester", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@semester", semester);

                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    Console.WriteLine(
                        $"{dr["CourseId"]}\t{dr["CourseName"]}\t{dr["Credits"]}\t{dr["Semester"]}"
                    );
                }

                dr.Close();
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
