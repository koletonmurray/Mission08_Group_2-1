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
            modelBuilder.Entity<Task>().HasData(
                new Task
                {
                    Id = 1,
                    Name = "404 Exam",
                    DueDate = "2023-02-25",
                    Quadrant = 1,
                    CategoryId = 2,
                    Completed = false
                }, 
                new Task
                {
                    Id = 6,
                    Name = "Test",
                    DueDate = "2023-02-25",
                    Quadrant = 3,
                    CategoryId = 3,
                    Completed = true
                },
                new Task
                {
                    Id = 2,
                    Name = "Call Doctor",
                    DueDate = "2023-02-28",
                    Quadrant = 3,
                    CategoryId = 5,
                    Completed = false
                },
                new Task
                {
                    Id = 3,
                    Name = "Date Night",
                    DueDate = "2023-03-04",
                    Quadrant = 2,
                    CategoryId = 5,
                    Completed = false
                },
                new Task
                {
                    Id = 4,
                    Name = "COD with the Boyz",
                    DueDate = "2023-03-04",
                    Quadrant = 4,
                    CategoryId = 5,
                    Completed = false
                },
                new Task
                {
                    Id = 5,
                    Name = "Church",
                    DueDate = "2023-02-19",
                    Quadrant = 2,
                    CategoryId = 4,
                    Completed = true
                }
            );
        }
    }
}
