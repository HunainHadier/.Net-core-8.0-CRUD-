using System.ComponentModel.DataAnnotations;

namespace crupapp.Models
{
    public class UserReg
    {
        [Key]

        public int ID { get; set; }
        [Required(ErrorMessage = "Write your name")]
        [StringLength(10, ErrorMessage = "Write only 10 chaaracter")]
        public string NAME { get; set; }

        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "PLease enter valid phone number")]
        public string PHONE { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(10, ErrorMessage = "Password must be at least 8 characters long")]
        public string PASSWORD { get; set; }


    }
}
