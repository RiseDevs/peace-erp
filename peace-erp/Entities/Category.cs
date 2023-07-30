using peace_erp.Entities.Enum;

namespace peace_erp.Entities;

public class Category
{
    public int Id;
    public string Name = "";
    public CategoryTypeEnum Type = CategoryTypeEnum.Budget;
    public int ParentId;
}
