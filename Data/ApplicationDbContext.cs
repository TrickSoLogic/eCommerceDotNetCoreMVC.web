using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eCommerceDotNetCoreMVC.web.Models;

namespace eCommerceDotNetCoreMVC.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<eCommerceDotNetCoreMVC.web.Models.Product>? Product { get; set; }
        public DbSet<eCommerceDotNetCoreMVC.web.Models.Order>? Order { get; set; }
        public DbSet<eCommerceDotNetCoreMVC.web.Models.Cart>? Cart { get; set; }
        public DbSet<eCommerceDotNetCoreMVC.web.Models.Category>? Category { get; set; }
        public DbSet<eCommerceDotNetCoreMVC.web.Models.Brand>? Brand { get; set; }
        public DbSet<eCommerceDotNetCoreMVC.web.Models.Review>? Review { get; set; }
        public DbSet<eCommerceDotNetCoreMVC.web.Models.Payment>? Payment { get; set; }
    }
}