using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessModels.Command
{
    public static class GenreEnumerator
    {
        public const char Male = 'M';
        public const char Female = 'F';
    }
    
    public class HumanCommand
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public char Genre { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Age { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Height { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "The field {0} must be greater than {1}.")]
        public double Weight { get; set; }

        public void Validate()
        {
            if (Genre != GenreEnumerator.Male && Genre != GenreEnumerator.Female)
            {
                throw new Exception($"The genre can only be {GenreEnumerator.Male} or {GenreEnumerator.Female}");
            }
        }
    }
}
