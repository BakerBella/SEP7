using Eurowind_Application.DaoInterfaces;
using Eurowind_Application.LogicInterfaces;
using Eurowind_Domain.DTOs;
using Eurowind_Domain.Models;

namespace Eurowind_Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDao userDao;

    public UserLogic(IUserDao userDao)
    {
        this.userDao = userDao;
    }

    public async Task<User> CreateAsync(UserCreationDto dto)
    {
        User? existing = await userDao.GetByUsernameAsync(dto.UserName);
        if (existing != null)
            throw new Exception("Username already taken");

        ValidateData(dto);
        User toCreate = new User
        {
            UserName = dto.UserName,
            Password = dto.Password,
            SecurityLevel = dto.SecurityLevel
        };

        User created = await userDao.CreateAsync(toCreate);

        return created;
    }
    
    private static void ValidateData(UserCreationDto userToCreate)
    {
        string userName = userToCreate.UserName;
        string password = userToCreate.Password;

        if (userName.Length < 3)
            throw new Exception("Username must be at least 3 characters!");

        if (userName.Length > 15)
            throw new Exception("Username must be less than 16 characters!");
        
        if (password.Length < 8)
            throw new Exception("Password must be at least 8 characters!");

        if (password.Length > 15)
            throw new Exception("Password must be less than 16 characters!");
    }
    
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters)
    {
        return userDao.GetAsync(searchParameters);
    }
}