using DataLayer.Entity;
using Employes.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Employes.Models
{
    public class EmployeeModel: PageModel
    {
        public IList<Employee> Emplooyees { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public int? EmployeeId { get; set; }
        //public SelectList? Genres { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public string? MovieGenre { get; set; }
    }
}
