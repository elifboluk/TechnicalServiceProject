using TechnicalServiceProject.Core.Entities;
using TechnicalServiceProject.Data.EntityFramework;
using TecnicalServiceProject.Business.Repositories.Abstracts.EntityFrameworkCore;
//using TecnicalServiceProject.Core.Entities;
//using TecnicalServiceProject.Data.EntityFramework;

namespace TecnicalServiceProject.Business.Repositories
{
    public class OperationRepo : RepositoryBase<Operation, int>
    {
        public OperationRepo(MyContext context) : base(context)
        {
        }
    }
}
