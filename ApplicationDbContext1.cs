using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Candysshop.Pages;

namespace CandysShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Candysshop.Pages.Candyss> Candyss { get; set; }
        public DbSet<Candysshop.Pages.Manufacturer> Manufacturer { get; set; }
        public DbSet<Candysshop.Pages.Store> Store { get; set; }
    }
}
