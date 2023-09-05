using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels
{
    public class Human
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "char")]
        public char Genre { get; set; }

        [Required]
        public int Age { get; set; }
        
        [Required]
        public int Height { get; set; }

        [Required]
        public double Weight { get; set; }
    }
}
