using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JETech.SIC.Web.Models;

namespace JETech.SIC.Web.Data.Entities
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> opcions):base(opcions)
        {
        }
        public DbSet<JETech.SIC.Web.Models.AddUserViewModel> AddUserViewModel { get; set; }
        
    }
}
