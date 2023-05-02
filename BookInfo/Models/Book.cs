using System.ComponentModel.DataAnnotations;

namespace BookInfo.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
