using peace_erp.Domain.Entities.Enum;

namespace peace_erp.Domain.Entities
{
    public class Category
    {
        public int Id;
        public string Name = "";
        public CategoryTypeEnum Type = CategoryTypeEnum.Budget;
        public int ParentId;
    }
}
