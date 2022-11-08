using System.ComponentModel.DataAnnotations;
public class usersModel
{
    [Key]
    public string id { get; set; } = "";
    public string Username { get; set; } = "";
    public string NormalizedUserName { get; set; } = "";
    public string Email { get; set; } = "";
    public string NormalizedEmail { get; set; } = "";
    public bool EmailConfirmed { get; set; } = false;
    public string PasswordHash { get; set; } = "";
    public string SecurityStamp { get; set; } = "";
    public string ConcurrencyStamp { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public bool PhoneNumberConfirmed { get; set; } = false;
    public bool TwoFactorEnabled { get; set; } = false;
    public DateTime LockoutEnd { get; set; }
    public bool LockoutEnabled { get; set; } = false;
    public int AccessFailedCount { get; set; } = 0;

}