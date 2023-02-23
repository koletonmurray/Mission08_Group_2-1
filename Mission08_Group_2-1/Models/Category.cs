using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission08_Group_2_1.Models
{
    public class Category
    {
        [Key][Required]public int Id { get; set; }
        [Required]public string Name { get; set; }
    }
}
