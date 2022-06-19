using TechnicalServiceProject.Core.Entities.Abstracts;

namespace TechnicalServiceProject.Core.Entities;

public class Product : BaseEntity<int>
{
    public string Name { get; set; }

    public IList<Request>? Requests { get; set; }
}