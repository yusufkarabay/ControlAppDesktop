using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF
{
    public class ControlAppDbContext : DbContext
    {
        public ControlAppDbContext(DbContextOptions<ControlAppDbContext> options) : base(options) {
           
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
