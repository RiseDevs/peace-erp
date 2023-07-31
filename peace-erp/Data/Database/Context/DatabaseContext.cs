using Microsoft.EntityFrameworkCore;
using peace_erp.Data.Features.AccountTypes.Repositories.Disk.Entities;
using peace_erp.Data.Features.BilingTypes.Repositories.Disk.Entities;
using peace_erp.Data.Features.DocumentTypes.Repositories.Disk.Entities;
using peace_erp.Data.Features.PersonLegals.Repositories.Disk.Entities;
using peace_erp.Data.Features.PersonTypes.Repositories.Disk.Entities;

namespace peace_erp.Data.Database.Context;

public class DatabaseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("peace-erp");
    }

    public DbSet<AccountType> AccountTypes { get; set; }
    public DbSet<BilingType> BilingTypes { get; set; }
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<PersonType> PersonTypes { get; set; }
    public DbSet<PersonLegal> PersonLegals { get; set; }
}
