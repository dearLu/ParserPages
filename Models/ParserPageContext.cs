using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParserPages.Models
{
    public class ParserPageContext : DbContext
    {
        public DbSet<StaticItem> StaticItems { get; set; }
        public ParserPageContext(DbContextOptions<ParserPageContext> options)
            : base(options)
        {
            Database.EnsureCreated();

        }
        
    }
}
