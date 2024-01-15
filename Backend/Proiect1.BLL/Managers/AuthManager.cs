using Microsoft.AspNetCore.Identity;
using Proiect1.BLL.Interfaces;
using Proiect1.DAL.Entities;
using Proiect1.BLL.Models;
using System.Threading.Tasks;
using Proiect1.BLL.DTOs;
using Proiect1.Services.Models;

namespace Proiect1.BLL.Managers;

public class AuthManager : IAuthManager
{
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IUserManager _manager;
    private readonly ITokenHelper _tokenHelper;

    public AuthManager(UserManager<User> userManager,
        SignInManager<User> signInManager,
        RoleManager<Role> roleManager,
        ITokenHelper tokenHelper,
        IUserManager manager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
        _tokenHelper = tokenHelper;
        this._manager = manager;
    }

    public async Task<LoginResult> Login(LoginModel loginModel)
    {
        var user = await _userManager.FindByEmailAsync(loginModel.Email);
        if (user == null)
            return new LoginResult
            {
                Success = false
            };
        else
        {
            var result = await _signInManager.CheckPasswordSignInAsync(user, loginModel.Password, false);
            if (result.Succeeded)
            {
                var token = await _tokenHelper.CreateAccessToken(user);
                var refreshToken = _tokenHelper.CreateRefreshToken();

                user.RefreshToken = refreshToken;
                await _userManager.UpdateAsync(user);

                return new LoginResult
                {
                    Success = true,
                    AccessToken = token,
                    RefreshToken = refreshToken
                };
            }
            else
                return new LoginResult
                {
                    Success = false
                };
        }    
    }

    public async Task<bool> Register(RegisterModel registerModel)
    {
        var user = new User
        {
            Email = registerModel.Email,
            UserName = registerModel.Name,
        };

        var result = await _userManager.CreateAsync(user, registerModel.Password);

        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, registerModel.Role);
            //var receiver = new EmailReceiverDTO
            //{
            //    Email = registerModel.Email,
            //    Name = registerModel.Name
            //};
            //await _manager.SendEmailTemplate(receiver);
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<bool> CreateRole(RoleModel roleModel)
    {
        var role = new Role
        {
            Name = roleModel.Name
        };

        var result = await _roleManager.CreateAsync(role);

        return result.Succeeded;
    }
}
