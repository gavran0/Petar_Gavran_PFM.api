using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.DTO
{
    public class TransactionSplitDto
    {
        public double Amount { get; set; }
        public string CatCode { get; set; } = default!;
    }
}
