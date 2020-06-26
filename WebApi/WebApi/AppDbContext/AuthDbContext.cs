using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.AppDbContext
{
    public class AuthDbContext: IdentityDbContext
    {
        public AuthDbContext(DbContextOptions options) : base(options) { }


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}