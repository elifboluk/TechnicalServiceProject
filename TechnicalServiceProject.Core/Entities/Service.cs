using TechnicalServiceProject.Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceProject.Core.Entities
{
    public class Service : BaseEntity<int>
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; } = 0;
    }
}
