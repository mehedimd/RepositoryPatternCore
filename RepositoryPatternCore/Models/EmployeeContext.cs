using Microsoft.EntityFrameworkCore;

namespace RepositoryPatternCore.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> option) : base(option)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
