using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(20, ErrorMessage = "Max 20 characters allowed")]
        public string Name { get; set; } = string.Empty;

        [Range(0, 999999)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required(ErrorMessage = "Category Required"), MaxLength(20)]
        public string? Category { get; set; }

        [RegularExpression(@"^[A-Z]*$",
         ErrorMessage = "Only capital letters allowed")]
        public string? Shelf { get; set; }

        [Range(0, 999999)]
        public int Count { get; set; }

        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        public string? Description { get; set; }

    }
}
