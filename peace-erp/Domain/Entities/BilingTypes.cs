using peace_erp.Domain.Entities.Base;

namespace peace_erp.Domain.Entities;

public class BilingTypes : BaseEntity
{
    public string Description { get; set; }
    public ShownAt ShownAt { get; set; }
}
