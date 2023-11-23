using System.ComponentModel.DataAnnotations;
using Eurowind_Domain.Models;

namespace Eurowind_Application.Shared;

public class AuthService : IAuthService
{
    private readonly IList<User> users = new List<User>
    {
        new User
        {
            UserName = "trmo",
            Password = "onetwo3FOUR",
            SecurityLevel = 2
        },
        new User
        {
            UserName = "jknr",
            Password = "password",
            SecurityLevel = 1
        }
    };

    public Task<User> ValidateUser(string username, string password)
    {
        User? existingUser = users.FirstOrDefault(u =>
            u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));

        if (existingUser == null)
        {
            throw new Exception("User not found");
        }

        if (!existingUser.Password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }

        return Task.FromResult(existingUser);
    }

    public Task<User> GetUser(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task RegisterUser(User user)
    {
        if (string.IsNullOrEmpty(user.UserName))
        {
            throw new ValidationException("Username cannot be null");
        }

        if (string.IsNullOrEmpty(user.Password))
        {
            throw new ValidationException("Password cannot be null");
        }

        // Check if the username is already taken
        if (users.Any(u => u.UserName.Equals(user.UserName, StringComparison.OrdinalIgnoreCase)))
        {
            throw new ValidationException("Username is already taken");
        }
        users.Add(user);

        return Task.CompletedTask;
    }
}