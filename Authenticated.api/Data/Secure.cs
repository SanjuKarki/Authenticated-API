using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Autheticated.api.Data;

public class Secure : IdentityDbContext<IdentityUser>
{
    public Secure(DbContextOptions<Secure> options) : base(options)
    { }
}