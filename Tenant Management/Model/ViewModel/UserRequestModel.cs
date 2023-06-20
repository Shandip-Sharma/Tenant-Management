using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tenant_Management.Model.ViewModel
{
    public class UserRequestModel
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int? UserType { get; set; }
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; } =string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [NotMapped]
        [Required]
        [Compare("Password",ErrorMessage ="Password didn't match !! try again")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
     public class UserClass
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int UserType { get; set; }
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [NotMapped]
        [Required]
        [Compare("Password", ErrorMessage = "Password didn't match !! try again")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
