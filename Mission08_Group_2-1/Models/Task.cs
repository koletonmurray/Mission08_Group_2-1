using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission08_Group_2_1.Models
{
    public class Task
    {
        [Key][Required] public int Id { get; set; }

        [Required] public string Name { get; set; }

        public string DueDate { get; set; }

        [Required(AllowEmptyStrings = false)] public int Quadrant { get; set; }

        [Required(AllowEmptyStrings = false)] public int CategoryId { get; set; }

        public Category TaskCategory { get; set; }

        public bool Completed { get; set; }
    }
}
