using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Security.Data;
using Security.Models;
namespace Security.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<usersModel> usersModel { get; set; }
    public DbSet<rolesModel> rolesModel { get; set; }
    public DbSet<userrolesModel> userrolesModel { get; set; }
    public DbSet<userclaimsModel> userclaimsModel { get; set; }
    public DbSet<rolesClaimsModel> roleClaimsModel { get; set; }


}
