using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Models
{
    public class ApplicationUser : IdentityUser
    {
        [NotMapped]
        [Required]
        public string? Password { get; set; }
    }
}
