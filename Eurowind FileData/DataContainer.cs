using Eurowind_Domain.Models;

namespace Eurowind_FileData;

public class DataContainer
{
    public ICollection<User> Users { get; set; }
    public ICollection<Post> Posts { get; set; }
}