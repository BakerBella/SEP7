using System.Security.Claims;
using Eurowind_Domain.Models;

namespace Eurowind_Blazor_Server_App.Services;

public interface IAuthService
{
    public Task LoginAsync(string username, string password);
    public Task LogoutAsync();
    public Task RegisterAsync(User user);
    public Task<ClaimsPrincipal> GetAuthAsync();
    Task<User> GetCurrentUser();
    public Action<ClaimsPrincipal> OnAuthStateChanged { get; set; }
}