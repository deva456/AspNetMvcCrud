using AspNetMvcCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcCrud.Data
{
    public class MVCDemoDbContext: DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options) 
        { 

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
