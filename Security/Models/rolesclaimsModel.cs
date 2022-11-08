using System.ComponentModel.DataAnnotations;
public class rolesClaimsModel
{
    [Key]
    public int Id { get; set; } = 0;
    public string RoleId { get; set; } = "";
    public string ClaimType { get; set; } = "";
    public string ClaimValue { get; set; } = "";
}