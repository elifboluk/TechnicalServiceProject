using TechnicalServiceProject.Core.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceProject.Core.Dtos
{
    public class ServiceDto : BaseDto<int>
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
