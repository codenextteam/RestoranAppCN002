using RestoranAppCN002.Abstarct;

namespace RestoranAppCN002.Cocrete
{
    internal class CategoryManager(ICheckRoleService checkRoleService, User user) : AbstractCategoryManager
    {
        private readonly ICheckRoleService _roleService = checkRoleService;
        public override void Add(Category category)
        {
            if (_roleService.CheckUserRole(user))
            {
                base.Add(category);

            }
            else
                Console.WriteLine("Bu operation ucun icazeniz yoxdur");
        }
    }
}
