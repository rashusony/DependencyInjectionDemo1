using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Models
{
    public interface IEmpFunction
    {

        Employee GetEmployee(int id);
    }
}
