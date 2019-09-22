using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using _4ALLweb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace LoginDBContext.Models
{
    public class LoginDBContext : DbContext
    {

        public LoginDBContext(DbContextOptions<LoginDBContext> options)
            : base(options)
        { }
        
        [Key]

        public DbSet<UserData> FirstName { get; set; }
        public DbSet<UserData> LastName { get; set; }
        public DbSet<UserData> Email { get; set; }
        public DbSet<UserData> UserName { get; set; }
        public DbSet<UserData> Password { get; set; }
        public DbSet<UserData> City { get; set; }
        public DbSet<UserData> State { get; set; }
        public DbSet<UserData> Zip { get; set; }
        public DbSet<UserData> PhoneNumber { get; set; }
    }
}

                

