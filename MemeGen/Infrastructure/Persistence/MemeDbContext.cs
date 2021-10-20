using System.Reflection;
using MemeGen.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MemeGen.Infrastructure.Persistence
{
    public class MemeDbContext: DbContext
    {
        public MemeDbContext(DbContextOptions options): base(options) { }

        public DbSet<MemeTemplate> MemeTemplates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
