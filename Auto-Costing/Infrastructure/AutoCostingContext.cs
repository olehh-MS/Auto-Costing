using Auto_Costing.Models;
using Microsoft.EntityFrameworkCore;

namespace Auto_Costing.Infrastructure
{
    public class AutoCostingContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AutoCostingContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("MySqlConnection"));
        }

        public DbSet<LS_Tables> LS_Tables { get; set; }
        public DbSet<LS_LayerGroups> LS_LayerGroups { get; set; }
        public DbSet<LS_Layers> LS_Layers { get; set; }
        public DbSet<LS_Cells> LS_Cells { get; set; }
        public DbSet<RawMaterials> RawMaterials { get; set; }

    }
}
