using System.ComponentModel.DataAnnotations;
public class userrolesModel
{
    [Key]
    public string UserId { get; set; } = "";
    public string RoleId { get; set; } = "";
}