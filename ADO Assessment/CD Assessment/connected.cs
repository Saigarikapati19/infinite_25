using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Assessment
{
    internal class connected
    {
        public void DisplayAllCourses()
        {

            SqlConnection con = new SqlConnection("Integrated Security=true;Database=Archi;Server=(localdb)\\MSSQLLocalDB");

            try
            {
                con.Open();
                
                SqlCommand cmd = new SqlCommand("select CourseId, CourseName, Credits, Semester from Courses", con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

               
                while (dr.Read())
                {
                    Console.WriteLine($"{dr["CourseId"]}\t\t{dr["CourseName"]}\t{dr["Credits"]}\t{dr["Semester"]}");
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
        public void AddNewStudent
            (string fullName, string email,
            string department, int yearOfStudy)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;Database=Archi;Server=(localdb)\\MSSQLLocalDB");

            try
            {
                con.Open();

                string query = "insert into Students (FullName, Email, Department, YearOfStudy) " +
                               "values (@FullName, @Email, @Department, @YearOfStudy)";

                SqlCommand cmd = new SqlCommand(query, con);

                
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@YearOfStudy", yearOfStudy);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("Student added successfully!");
                else
                    Console.WriteLine("Failed to add student.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("sql Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void ByDepartment()
        {
            Console.Write("Enter the Department Name: ");
            string department = Console.ReadLine();

            SqlConnection conn = new SqlConnection("Integrated security=true;database=Archi;server=(localdb)\\MSSQLLocalDB");
            conn.Open();

            string query = "select StudentId, FullName, Email, Department, YearOfStudy " +
                "from Students where Department = @Department";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Department", department);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Students in " + department);
            while (reader.Read())
            {
                Console.WriteLine(reader["StudentId"] + " - " + reader["FullName"] + " - " + reader["Email"] + " - " + reader["YearOfStudy"]);
            }
            conn.Close();
        }
        public void DisplayEnrolledCoureses(int studentId)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;Database=Archi;Server=(localdb)\\MSSQLLocalDB");

            try
            {
                con.Open();

                string query = @"select c.CourseName, c.Credits, e.EnrollDate, e.Grade
                             from Enrollments e
                             inner join Courses c ON e.CourseId = c.CourseId
                             where e.StudentId = @StudentId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                SqlDataReader dr = cmd.ExecuteReader();                

                while (dr.Read())
                {
                    string courseName = dr["CourseName"].ToString();
                    int credits = Convert.ToInt32(dr["Credits"]);
                    DateTime enrollDate = Convert.ToDateTime(dr["EnrollDate"]);
                    string grade = dr["Grade"] == DBNull.Value ? "N/A" : dr["Grade"].ToString();

                    Console.WriteLine($"{courseName}\t{credits}\t{enrollDate.ToShortDateString()}\t{grade}");
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
        public void UpdateGrade(int enrollmentId, string grade)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;Database=Archi;Server=(localdb)\\MSSQLLocalDB");

            try
            {
                con.Open();               
                string query = "UPDATE Enrollments SET Grade = @Grade WHERE EnrollmentId = @EnrollmentId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@EnrollmentId", enrollmentId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("Grade updated successfully!");
                else
                    Console.WriteLine("No enrollment found with the given ID.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
    }


}

    
