using Microsoft.AspNetCore.Identity;

namespace DigiWalletApi.Repos.Interface
{
    public interface ITokenRepo
    {
        string CreateJWTToken(IdentityUser<Guid> user, List<string> roles);
    }
}
