using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Models
{
    public class Designation
    {
        public string Country { get; set; }

        public List<SelectListItem> countries = new List<SelectListItem>()
        {
            new SelectListItem{Value="Mx" ,Text="Maxico"},
             new SelectListItem{Value="In" ,Text="India"},
              new SelectListItem{Value="Au" ,Text="Australia"}
        };
    }
}
