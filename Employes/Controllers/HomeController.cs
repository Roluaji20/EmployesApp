using DataLayer.EmployeeService;
using DataLayer.Entity;
using Employes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Employes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeData employeeData;

        public HomeController(ILogger<HomeController> logger, IEmployeeData employeeData)
        {
            _logger = logger;
            this.employeeData = employeeData;
        }

        public async Task OnGetAsync()
        {
           
        }


        public  async  Task<IActionResult> Index(int? EmployeeId)
        {

            //GetEmployees
            try
            {
                var employees = await employeeData.GetEmployees();

               // var EmpoyeebyId = await employeeData.GetEmployeeById(1);

                if (EmployeeId is not null)
                {
                    employees = employees.Where(s => s.id ==EmployeeId);
                }

                employees =  employees.ToList();

                //var model = new EmployeeModel
                //{
                //    Emplooyees = (IList<Employee>)employees
                //};

                return View(employees);
            }
            catch (Exception ex)
            {

                throw ex;
            } 

            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    
}