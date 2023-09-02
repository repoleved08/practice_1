using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_MS.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_MS.Data
{
    public class AppDbContext : DbContext
    {
        internal readonly object Users;

        public DbSet<UserClass> userClasses { get; set; }
        public DbSet<EventClass> eventClasses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
