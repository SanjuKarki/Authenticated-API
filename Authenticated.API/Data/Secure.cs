using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Autheticated_API;

public class DBContext : IdentityDbContext<IdentityUser>
{
    public Secure(DbContextOptions<Secure> options) : base(options)
    { }
}