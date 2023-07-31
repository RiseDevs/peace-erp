using peace_erp.Data.Database.Base;
using peace_erp.Data.Features.BilingTypes.Repositories.Disk.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace peace_erp.Data.Features.DocumentTypes.Repositories.Disk.Entities;

public class DocumentType : BaseEntity
{
    public string Description { get; set; }
    [ForeignKey("BilingType")]
    public int BilingTypeId { get; set; }


    public BilingType BilingType { get; set; }
}
