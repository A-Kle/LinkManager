using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkManager.Data
{
    public class LinkManagerContext : DbContext
    {
        public LinkManagerContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Link> Links { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
    }
}
