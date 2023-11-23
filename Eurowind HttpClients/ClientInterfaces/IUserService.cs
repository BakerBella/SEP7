using Eurowind_Domain.DTOs;
using Eurowind_Domain.Models;

namespace Eurowind_HttpClients.ClientInterfaces;

public interface IUserService
{
    Task<User> Create(UserCreationDto dto);
    Task<IEnumerable<User>> GetUsers(string? usernameContains = null);
    Task<User> GetUserById(int id); 
}