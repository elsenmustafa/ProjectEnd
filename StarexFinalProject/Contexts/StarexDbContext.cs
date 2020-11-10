using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StarexFinal.Data;
using StarexFinal.Models;
using StarexFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Contexts
{
    public class StarexDbContext : IdentityDbContext<AppUsers>
    {
        public StarexDbContext(DbContextOptions<StarexDbContext> options)
            : base(options)
        {

        }
      
        public DbSet<AppUsers> appUsers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<UserBalance> UserBalances { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Declarations> Declarations { get; set; }
        public DbSet<DeclarationsStatus> DeclarationsStatuses { get; set; }
        public DbSet<FormCategory> OnlineFormCategories { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
