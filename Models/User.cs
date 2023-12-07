namespace MatteoRbProject.Models;
public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public List<Application>? Applications { get; set; }
}

