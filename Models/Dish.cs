using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        [Required]
        [Column("dish_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DishId { get; set; }
        [Required]
        [MinLength(2)]
        [Column("name")]
        public string? Name { get; set; }
        [Required]
        [MinLength(2)]
        [Column("chef")]
        public string? Chef { get; set; }
        [Column("tastiness")]
        [Required]
        [Range(1, 5)]
        public int Tastiness { get; set; }
        [Required]
        [Range(1, 10000)]
        [Column("calories")]
        public int Calories { get; set; }
        [Required]
        [MinLength(2)]
        [Column("description", TypeName = "TEXT")]
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}