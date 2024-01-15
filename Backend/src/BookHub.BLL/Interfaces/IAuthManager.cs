using BookHub.BLL.Models;
using BookHub.Services.Models;
using System.Threading.Tasks;

namespace BookHub.BLL.Interfaces;

public interface IAuthManager
{
    Task<bool> Register(RegisterModel registerModel);
    Task<LoginResult> Login(LoginModel loginModel);
    Task<bool> CreateRole(RoleModel roleModel);
}
