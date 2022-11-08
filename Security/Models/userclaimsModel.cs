using System.ComponentModel.DataAnnotations;
public class userclaimsModel
{
    [Key]
    public int Id { get; set; } = 0;
    public string UserId { get; set; } = "";
    public string ClaimType { get; set; } = "";
    public string ClaimValue { get; set; } = "";
}