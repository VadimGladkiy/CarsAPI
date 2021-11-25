using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace CarsAPI.Models
{
    public class Car
    {
        [Required]
        public string Make { get; set; }
        [Required]
        public string Type { get; set; }
        [Key]
        [Required]
        public string IdentificationNumber { get; set; }
        public int Year { get; set; }
        public int Mass { get; set; }
        public int Capacity { get; set; }
        [Required]
        public string Color { get; set; }
        public int NumberOfSeats { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
