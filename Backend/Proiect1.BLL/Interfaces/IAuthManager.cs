using Proiect1.BLL.Models;
using Proiect1.Services.Models;
using System.Threading.Tasks;

namespace Proiect1.BLL.Interfaces;

public interface IAuthManager
{
    Task<bool> Register(RegisterModel registerModel);
    Task<LoginResult> Login(LoginModel loginModel);
    Task<bool> CreateRole(RoleModel roleModel);
}
