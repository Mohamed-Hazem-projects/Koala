using System.ComponentModel.DataAnnotations;

namespace KoalaInventoryManagement.ViewModels.Authentication
{
    public class ResetPasswordViewModel
    {

        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{6,}$", ErrorMessage = "Password must have at least one lowercase letter, one uppercase letter, one digit, one non-alphanumeric character, and be at least 6 characters long.")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        [Compare(nameof(Password), ErrorMessage = "Confirm Password does not match Password")]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
        public string Token { get; set; }
    }
}
