using Microsoft.EntityFrameworkCore;
using RepositoryPatternCore.Models;

namespace RepositoryPatternCore.Services
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeContext context;
        // private DbSet<Employee> employee;
        public EmployeeRepository(EmployeeContext _eontext)
        {
            this.context = _eontext;
            // employee = context.Set<Employee>();
        }
        public void Delete(int ID)
        {
            context.Employees.Remove(context.Employees.Find(ID));
            context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetById(int ID)
        {
            return context.Employees.Find(ID);
        }

        public void Insert(Employee entity)
        {
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public void Update(Employee entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
