using Microsoft.AspNetCore.Mvc;
using RepositoryPatternCore.Models;
using RepositoryPatternCore.Services;

namespace RepositoryPatternCore.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployee employee;
        public EmployeeController(IEmployee _employee)
        {
            this.employee = _employee;
        }
        public IActionResult Index()
        {
            return View(employee.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            employee.Insert(emp);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(employee.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            employee.Update(emp);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            employee.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
