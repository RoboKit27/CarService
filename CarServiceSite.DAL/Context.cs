using CarServiceSite.Core.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CarServiceSite.DAL
{
    public class Context : DbContext
    {
        public DbSet<UserDto> Users { get; set; }
        public DbSet<RoleDto> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CarServiceSiteConnectionString"));
        }
    }
}
