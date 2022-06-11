using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProgFinal.Models;

namespace WebProgFinal.Data
{
    public class WebProgFinalContext : DbContext
    {
        public WebProgFinalContext (DbContextOptions<WebProgFinalContext> options)
            : base(options)
        {
        }

        public DbSet<WebProgFinal.Models.Person>? Person { get; set; }
    }
}
