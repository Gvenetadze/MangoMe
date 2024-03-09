using MangoMe.Services.EmailAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MangoMe.Services.EmailAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<EmailLogger> EmailLoggers { get; set; }

        
    }
}
