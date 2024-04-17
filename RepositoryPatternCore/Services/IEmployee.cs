using RepositoryPatternCore.Models;

namespace RepositoryPatternCore.Services
{
    public interface IEmployee
    {
        void Insert(Employee entity);
        void Update(Employee entity);
        void Delete(int ID);
        List<Employee> GetAll();
        Employee GetById(int ID);
    }
}
