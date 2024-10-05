using System.ComponentModel.DataAnnotations;

namespace KoalaInventoryManagement.ViewModels.Authentication
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid format of email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
