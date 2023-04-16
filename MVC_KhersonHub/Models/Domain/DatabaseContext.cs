using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace MVC_KhersonHub.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts)
        {

        }
        public DbSet<Immigrant> Immigrant { get; set; }
    }
}
