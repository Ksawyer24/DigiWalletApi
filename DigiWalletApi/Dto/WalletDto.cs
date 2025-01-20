using DigiWalletApi.Models;

namespace DigiWalletApi.Dto
{
    public class WalletDto
    {
        public Guid Id { get; set; }
        public string WalletName { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Currency { get; set; } = string.Empty;
        public Guid UserId { get; set; }

    }


    public class AddWalletDto
    {
        public string WalletName { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Currency { get; set; } = string.Empty;
        public Guid UserId { get; set; }
    }


    public class UpdateWalletDto
    {
        public string WalletName { get; set; } = string.Empty;
    }
}
