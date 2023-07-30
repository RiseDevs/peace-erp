using Microsoft.EntityFrameworkCore;
using peace_erp.Domain.Entities;

namespace peace_erp.Data.Database;

public class DatabaseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("peace-erp");
    }

    public DbSet<AccountTypes> AccountTypes { get; set; }
    public DbSet<BilingTypes> BilingTypes { get; set; }
    public DbSet<DocumentTypes> DocumentTypes { get; set; }
    public DbSet<PersonTypes> PersonTypes { get; set; }
    public DbSet<PersonLegals> PersonLegals { get; set; }
}
