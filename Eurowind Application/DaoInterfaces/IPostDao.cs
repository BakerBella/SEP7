using Eurowind_Domain.DTOs;
using Eurowind_Domain.Models;

namespace Eurowind_Application.DaoInterfaces;

public interface IPostDao
{
    Task<Post> CreateAsync(Post post);
    Task<IEnumerable<Post>> GetAsync(SearchPostParametersDto searchParameters);
    Task UpdateAsync(Post post);
    Task DeleteAsync(int id);
    Task<Post?> GetByIdAsync(int id);
}