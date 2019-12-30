using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.ViewModel
{
    public class EmployeeSearchViewModel
    {
        public Employee Employee { get; set; }
        public string PageTitle { get; set; }
    }
}
