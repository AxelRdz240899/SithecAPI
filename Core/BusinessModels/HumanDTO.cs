using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessModels
{
    public class HumanDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public char Genre { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
    }
}
