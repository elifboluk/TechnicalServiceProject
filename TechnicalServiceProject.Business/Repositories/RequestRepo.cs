using TechnicalServiceProject.Core.Entities;
using TechnicalServiceProject.Data.EntityFramework;
using TecnicalServiceProject.Business.Repositories.Abstracts.EntityFrameworkCore;
//using TecnicalServiceProject.Core.Entities;
//using TecnicalServiceProject.Data.EntityFramework;
namespace TecnicalServiceProject.Business.Repositories
{
    public class RequestRepo : RepositoryBase<Request, int>
    {
        public RequestRepo(MyContext context) : base(context)
        {

        }
    }
}
