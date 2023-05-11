using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WebApplication_.Models;

namespace WebApplication_.DAL
{
    public class AppDbContext:DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
         
        }
        public DbSet<Sliders>Sliders { get; set; }
    }
}
