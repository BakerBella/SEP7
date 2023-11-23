using System.Text.Json.Serialization;

namespace Eurowind_Domain.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    [JsonIgnore]
    public string Password { get; set; }
    public int SecurityLevel { get; set; }
}