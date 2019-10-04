using Microsoft.EntityFrameworkCore;
using System;

namespace _4ALLApp.Models
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> dbContextOptions)
                   : base(dbContextOptions) { }
        public DbSet<User> Users { get; set; }

    }
}