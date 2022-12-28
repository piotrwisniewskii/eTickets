using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage ="Email address is required")]
        public string EmaillAddress { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
