using peace_erp.Data.Database.Base;
using peace_erp.Domain.Entities.Enum;

namespace peace_erp.Data.Features.BilingTypes.Repositories.Disk.Entities;

public class BilingType : BaseEntity
{
    public string Description { get; set; }
    public ShownAt ShownAt { get; set; }
}
