using EmployeesRegister.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeesRegister.DataAccessLayer
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}