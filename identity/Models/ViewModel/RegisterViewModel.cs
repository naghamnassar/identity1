using System.ComponentModel.DataAnnotations;

namespace identity.Models.ViewModel
{
    public class RegisterViewModel
    {
       
        [Required]
        [EmailAddress]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(30)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [MaxLength(30)]
        public string ConfirmPassword { get; set; }
        [Required]

        public string Phone { get; set; }
        
    }
}
