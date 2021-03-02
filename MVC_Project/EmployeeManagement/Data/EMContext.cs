using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace  EmployeeManagement.Data
{
    public class EMContext :DbContext
    {
        public EMContext(DbContextOptions<EMContext>options):base(options)
        {

        }
        public DbSet<Employee> Employees{ get; set; }
    }
}