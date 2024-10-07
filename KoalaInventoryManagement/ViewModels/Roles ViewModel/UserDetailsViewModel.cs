using System.ComponentModel.DataAnnotations;

namespace KoalaInventoryManagement.ViewModels
{
    public class UserDetailsViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public IReadOnlyList<string> roles { get; set; }
    }
}
