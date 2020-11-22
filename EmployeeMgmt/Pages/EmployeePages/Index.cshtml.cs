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
    public class IndexModel : PageModel
    {
        private readonly EmployeeMgmt.Data.EmployeeMgmtContext _context;

        public IndexModel(EmployeeMgmt.Data.EmployeeMgmtContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
