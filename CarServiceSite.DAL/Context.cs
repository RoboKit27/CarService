using CarServiceSite.Core.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.DAL
{
    public class Context : DbContext
    {
        public DbSet<UserDto> Users { get; set; }
        public DbSet<RoleDto> Roles { get; set; }
        public DbSet<CommentDto> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CarServiceSiteConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommentDto>(c =>
            {
                c.HasOne(p => p.Addressee)
                .WithMany(p => p.CommentsAboutYou);
                c.HasOne(p => p.Author)
                .WithMany(p => p.YourComments);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
