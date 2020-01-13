using Microsoft.EntityFrameworkCore;
using NcServer.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NcServer.App
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserGroup>().HasKey(ug => new { ug.UserId, ug.GroupId });
            modelBuilder.Entity<Message>().HasOne<Group>(u => u.Group);
        
        }
    }
}
