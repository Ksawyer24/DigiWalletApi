using Microsoft.AspNetCore.Identity;

namespace DigiWalletApi.Repos.Interface
{
    public interface ITokenRepo
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
