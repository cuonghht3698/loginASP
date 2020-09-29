using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authent.Models
{
  public class AuthentContext : IdentityDbContext
  {
    public AuthentContext( DbContextOptions options) : base(options)
    {
    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
  }
}
