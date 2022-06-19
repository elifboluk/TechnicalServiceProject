using TechnicalServiceProject.Core.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceProject.Core.Dtos
{
    public class ProductDto : BaseDto<int>
    {
        public string Name { get; set; }

        public IList<RequestDto>? Requests { get; set; }
    }
}
