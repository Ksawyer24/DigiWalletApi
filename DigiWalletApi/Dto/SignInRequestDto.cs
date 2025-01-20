using System.ComponentModel.DataAnnotations;

namespace DigiWalletApi.Dto
{
    public class SignInRequestDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
