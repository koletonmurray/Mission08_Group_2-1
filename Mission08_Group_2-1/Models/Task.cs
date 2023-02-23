using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;

namespace Mission08_Group_2_1.Models
{
    public class Task
    {
        [Key][Required]public int Id { get; set; }
        public DateTime DueDate { get; set; }
        [Required]public int Quadrant { get; set; }
        [Required]public int CategoryId { get; set; }
        public Category TaskCategory { get; set; }
        public bool Completed { get; set; }
=======
using Microsoft.EntityFrameworkCore;

namespace Mission08_Group_2_1.Models
{
<<<<<<<< HEAD:Mission08_Group_2-1/Models/Context.cs
    public class Context : DbContext
========
    public class Task
>>>>>>>> master:Mission08_Group_2-1/Models/Task.cs
    {

>>>>>>> master
    }
}
