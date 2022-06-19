using TechnicalServiceProject.Core.Dtos.Abstract;
using TechnicalServiceProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceProject.Core.Dtos
{
    public class RequestDto : BaseDto<int>
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string TextOfRequest { get; set; }

        public string Address { get; set; }

        public bool Status { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }
    }
}
