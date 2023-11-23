using Eurowind_Domain.DTOs;
using Eurowind_Domain.Models;

namespace Eurowind_Application.LogicInterfaces;

public interface IUserLogic
{
    public Task<User> CreateAsync(UserCreationDto dto);
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);
}