using backendWork.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
namespace backendWork.DataAccessLayer
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
