using backendWork.DataAccessLayer;
using backendWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace backendWork.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();

            if (employees!= null)
            {
                
                foreach(var employee in employees)
                {
                    var EmployeeViewModel = new EmployeeViewModel()
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Email = employee.Email
                    };
                    employeeList.Add(EmployeeViewModel);
                }
                return View(employeeList);
            }
            return View();
        }
    }
}
