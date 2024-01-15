using BookHub.DAL.Entities;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookHub.BLL.Interfaces;

public interface ITokenHelper
{
    Task<string> CreateAccessToken(User _User);
    string CreateRefreshToken();
    ClaimsPrincipal GetPrincipalFromExpiredToken(string _Token);
}
