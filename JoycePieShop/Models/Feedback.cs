using System.ComponentModel.DataAnnotations;

namespace JoycePieShop.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        public bool ContactMe { get; set; }
    }
}
