using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Models
{
    public class EmployeeFunction:IEmpFunction
    {
        private List<Employee> empList;

        public EmployeeFunction()
        {
            empList = new List<Employee>()
            {
                new Employee(){Name="Rashmi",Designation="Software Developer",Id=1},
                new Employee(){Name="Rachel",Designation="Software Developer",Id=2},
                new Employee(){Name="Satish",Designation="Software tester",Id=3}
            };
        }
        
        public Employee GetEmployee(int id)
        {
            var emp = empList.FirstOrDefault(x => x.Id == id);

            return emp;
        }
    }
}
