using API.Entites;

namespace API.Intefaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}