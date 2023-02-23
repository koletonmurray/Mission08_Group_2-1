using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission08_Group_2_1.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            //Blank
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Home"},
                new Category {Id = 2, Name = "School"},
                new Category {Id = 3, Name = "Work"},
                new Category {Id = 4, Name = "Church"},
                new Category {Id = 5, Name = "Other"}
            );
        }
    }
}
