using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeMgmt.Models;

namespace EmployeeMgmt.Data
{
    public class EmployeeMgmtContext : DbContext
    {
        public EmployeeMgmtContext (DbContextOptions<EmployeeMgmtContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeMgmt.Models.Employee> Employee { get; set; }
    }
}
