using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.DTO
{
    public class CategoryDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? ParentCode { get; set; }
    }

}
