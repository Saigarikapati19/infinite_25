using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_salary_assignment
{
    internal class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double salary { get; set; }
            public int experience { get; set; }

            public override string ToString()
            {
                return $"Id: {Id}\nName: {Name}\nDepartment: {Department}\nSalary: {salary}\nExperience: {experience} yrs";
            }
        }
        internal class program
        {
            public static void Main(string[] args) //List<Employee> list = new List<Employee>()
            {
                List<Employee> list = new List<Employee>()
            {
                new Employee {Id = 1, Name = "SaiRam", Department = "IT", salary = 60000, experience = 6 },

                new Employee { Id = 2, Name = "Akshay", Department = "HR", salary = 45000, experience = 4 },
                new Employee { Id = 3, Name = "Mani", Department = "Finance", salary = 55000, experience = 7 },
                new Employee { Id = 4, Name = "Ashok", Department = "IT", salary = 70000, experience = 8 },
                new Employee { Id = 5, Name = "Vel", Department = "Sales", salary = 40000, experience = 3 },
                new Employee { Id = 6, Name = "Ragul", Department = "IT", salary = 52000, experience = 5 },
                new Employee { Id = 7, Name = "Sudalai", Department = "Finance", salary = 48000, experience = 4 },
                new Employee { Id = 8, Name = "Sai", Department = "HR", salary = 65000, experience = 9 },
                new Employee { Id = 9, Name = "Kanta", Department = "Sales", salary = 53000, experience = 6 },
                new Employee { Id = 10, Name = "Gari", Department = "IT", salary = 80000, experience = 7 }

                };
                Console.WriteLine("=== All Employees ===");
                foreach (var e in list)
                {
                    Console.WriteLine(e.Id + " " + e.Name + " " + e.Department + " " + e.salary + " " + e.experience);
                }



                // Salary > 50,000
                Console.WriteLine("\nEmployees with Salary > 50,000:");
                foreach (Employee e in list)
                {
                    if (e.salary > 50000)
                    {
                        Console.WriteLine(e);
                    }
                }

                // IT Department
                Console.WriteLine("\nEmployees in IT Department:");
                foreach (Employee e in list)
                {
                    if (e.Department == "IT")
                    {
                        Console.WriteLine(e);
                    }
                }

                // experience > 5 years
                Console.WriteLine("\nEmployees with Experience > 5 years:");
                foreach (Employee e in list)
                {
                    if (e.experience > 5)
                    {
                        Console.WriteLine(e);
                    }
                }

                // name starts with 'A'
                Console.WriteLine("\nEmployees whose name starts with 'A':");
                foreach (Employee e in list)
                {
                    if (e.Name.StartsWith("A"))
                    {
                        Console.WriteLine(e);
                    }
                }

                //Lambda
                var sortByName = list.OrderBy(e => e.Name);
                var sortBySalary = list.OrderByDescending(e => e.salary);
                var sortByExperience = list.OrderBy(e => e.experience);

                Console.WriteLine("\n=== Sorted by Name (A-Z) ===");
                foreach (var e in sortByName)
                {
                    Console.WriteLine(e.Id + "\t" + e.Name + "\t" + e.Department + "\t" + e.salary + "\t" + e.experience + " yrs");
                }

                Console.WriteLine("\n=== Sorted by Salary (High → Low) ===");
                foreach (var e in sortBySalary)
                {
                    Console.WriteLine(e.Id + "\t" + e.Name + "\t" + e.Department + "\t" + e.salary + "\t" + e.experience + " yrs");
                }

                Console.WriteLine("\n=== Sorted by Experience (Low → High) ===");
                foreach (var e in sortByExperience)
                {
                    Console.WriteLine(e.Id + "\t" + e.Name + "\t" + e.Department + "\t" + e.salary + "\t" + e.experience + " yrs");
                }

                //Experience > 8 years
                var promotionList = list.Where(e => e.experience > 8);
                Console.WriteLine("\n=== Promotion List");
                foreach (var e in promotionList)
                {
                    Console.WriteLine(e.Id + "\t" + e.Name + "\t" + e.Department + "\t" + e.salary + "\t" + e.experience + " yrs");
                }
            }


        }  
    }
}
