using Microsoft.EntityFrameworkCore;
using Musique.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Musique.Data
{
    public class MusiqueDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MusiqueDbContext(DbContextOptions<MusiqueDbContext> options) : base(options)
        {

        }
    }
}
