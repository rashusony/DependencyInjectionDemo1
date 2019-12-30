using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.ViewModel;

namespace DependencyInjectionDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmpFunction _employeeFunc;
        public EmployeeController(IEmpFunction employeeFunc)
        {
            _employeeFunc = employeeFunc;
        }
        public IActionResult Index()
        {
            return View();
        }


       // [Route("xyz/index")]
       [HttpPost]
        public IActionResult Search(Employee empi)
        {
            int id = empi.Id;
            EmployeeSearchViewModel employeeSearchViewModel = new EmployeeSearchViewModel()
            {
                Employee = _employeeFunc.GetEmployee(id),
                PageTitle = "The details of Employee"
            };
            
          //  Employee emp = _employeeFunc.GetEmployee(id);
            return View(employeeSearchViewModel);
        }

        public IActionResult LearnSelectList()
        {
            return View();
        }
    }
}