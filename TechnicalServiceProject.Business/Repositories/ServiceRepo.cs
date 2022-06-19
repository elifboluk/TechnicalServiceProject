using TechnicalServiceProject.Core.Entities;
using TechnicalServiceProject.Data.EntityFramework;
using TecnicalServiceProject.Business.Repositories.Abstracts.EntityFrameworkCore;


namespace TecnicalServiceProject.Business.Repositories
{
    public class ServiceRepo : RepositoryBase<Service, int>
    {
        public ServiceRepo(MyContext context) : base(context)
        {

        }
    }
}
