using TechnicalServiceProject.Core.Entities;
using TechnicalServiceProject.Data.EntityFramework;
using TecnicalServiceProject.Business.Repositories.Abstracts.EntityFrameworkCore;
//using TecnicalServiceProject.Core.Entities;
//using TecnicalServiceProject.Data.EntityFramework;

namespace TecnicalServiceProject.Business.Repositories
{
    public class ProductRepo : RepositoryBase<Product, int>
    {
        public ProductRepo(MyContext context) : base(context)
        {
        }
    }
}
