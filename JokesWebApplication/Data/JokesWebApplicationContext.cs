using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesWebApplication.Models;

namespace JokesWebApplication.Data
{
    public class JokesWebApplicationContext : DbContext
    {
        public JokesWebApplicationContext (DbContextOptions<JokesWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<JokesWebApplication.Models.Joke> Joke { get; set; } = default!;
    }
}
