using GuniApplication.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuniApplication.Web.Data
{
    public class ApplicationDbContext 
        : IdentityDbContext<MyIdentityUser,MyIdentityRole,Guid>
    {

        public DbSet<Department> Departments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
