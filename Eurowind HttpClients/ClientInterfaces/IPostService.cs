using Eurowind_Domain.DTOs;
using Eurowind_Domain.Models;

namespace Eurowind_HttpClients.ClientInterfaces;

public interface IPostService
{
    Task CreateAsync(PostCreationDto dto);

    Task<ICollection<Post>> GetAsync(
        string? userName,
        int? userId,
        string? titleContains,
        string? bodyContains
    );
    Task<PostBasicDto> GetByIdAsync(int id);
}