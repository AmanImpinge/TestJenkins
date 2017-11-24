using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCCoreApp.DBContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.DBContext
{
    public class TestDBContext : IdentityDbContext<ApplicationUser>
    {
        public TestDBContext(DbContextOptions<TestDBContext>options):base(options)
        {

        }
        public DbSet<Test> Test { get; set; }
    }
}
