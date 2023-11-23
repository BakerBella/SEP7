using System.ComponentModel.DataAnnotations;

namespace Eurowind_Domain.Models;

public class Post
{
    [Key]
    public int Id { get; set; }
    public User Owner { get; private set; }
    public int OwnerId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public Post(int ownerId, string title, string body)
    {
        OwnerId = ownerId;
        Title = title;
        Body = body;
    }
    
    public Post(){}
}