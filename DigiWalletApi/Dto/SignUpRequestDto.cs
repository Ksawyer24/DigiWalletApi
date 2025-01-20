using System.ComponentModel.DataAnnotations;

namespace DigiWalletApi.Dto
{
    public class SignUpRequestDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;

        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Required]
        public required string[] Roles { get; set; } 
    }
}
