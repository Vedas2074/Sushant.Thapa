using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace  EmployeeManagement.Data
{
    public class DMContext :DbContext
    {
        public DMContext(DbContextOptions<EMContext>options):base(options)
        {

        }
        public DbSet<Department> Departments{ get; set; }
    }
}