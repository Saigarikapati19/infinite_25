using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web.Http;
using Codechallenge9._2.Models;
namespace Codechallenge9._2.Models
{
    [RoutePrefix("api/orders")]
    public class CustomersController : ApiController
    {
        NorthwindEntities1 db = new NorthwindEntities1();

        [HttpGet]
        [Route("Getbyempid")]
        public IHttpActionResult GetOrdersByEmployee(int employeeId)
        {

            var orders = db.Orders
                       .Where(o => o.EmployeeID == employeeId)
                       .Select(o => new
                       {
                           o.OrderID,
                           o.OrderDate,
                           o.CustomerID,
                           CompanyName = o.Customer.CompanyName,
                           ContactName = o.Customer.ContactName,
                           EmployeeName = o.Employee.FirstName + " " + o.Employee.LastName
                       })
                       .ToList();

            return Ok(orders);

        }

        [HttpGet]
        [Route("country")]
        public IHttpActionResult GetCustomersByCountry(string country)
        {
            var customers = db.Database.SqlQuery<Customer>(
                "EXEC GetCustomersByCountry @Country",
                new SqlParameter("@Country", country)
            ).ToList();

            return Ok(customers);
        }


    }

}