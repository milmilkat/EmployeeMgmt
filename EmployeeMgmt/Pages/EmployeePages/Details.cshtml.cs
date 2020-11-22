using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeMgmt.Data;
using EmployeeMgmt.Models;

namespace EmployeeMgmt
{
    public class DetailsModel : PageModel
    {
        private readonly EmployeeMgmt.Data.EmployeeMgmtContext _context;

        public DetailsModel(EmployeeMgmt.Data.EmployeeMgmtContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.Id == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
