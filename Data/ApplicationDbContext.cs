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
    }
}