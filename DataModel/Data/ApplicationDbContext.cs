using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public IConfiguration Configuration { get; set; }
        public ApplicationDbContext(IConfiguration configuration, DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            Configuration = configuration;
        }

        public DbSet<ComponentModel> Components { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
