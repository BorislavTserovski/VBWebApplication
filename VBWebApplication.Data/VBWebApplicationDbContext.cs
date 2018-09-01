using VBWebApplication.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace VBApp.Data
{
    public class VBWebApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public VBWebApplicationDbContext(DbContextOptions<VBWebApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}