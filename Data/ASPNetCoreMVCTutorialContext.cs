using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNetCoreMVCTutorial.Models;

namespace ASPNetCoreMVCTutorial.Data
{
    public class ASPNetCoreMVCTutorialContext : DbContext
    {
        public ASPNetCoreMVCTutorialContext (DbContextOptions<ASPNetCoreMVCTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNetCoreMVCTutorial.Models.Movie> Movie { get; set; } = default!;
    }
}
