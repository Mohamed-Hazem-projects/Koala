using System.ComponentModel.DataAnnotations;

namespace Inventory.web.Models
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid format of email")]
        public string Email { get; set; }
    }
}
