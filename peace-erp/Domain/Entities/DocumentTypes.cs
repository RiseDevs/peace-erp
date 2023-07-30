using peace_erp.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace peace_erp.Domain.Entities;

public class DocumentTypes : BaseEntity
{
    public string Description { get; set; }
    [ForeignKey("BilingType")]
    public int BilingTypeId { get; set; }


    public BilingTypes BilingType { get; set; }
}
