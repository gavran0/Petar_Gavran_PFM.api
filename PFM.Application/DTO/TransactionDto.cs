using PFM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.DTO
{
    public class TransactionDto
    {
        public string Id { get; set; }
        public string CatCode { get; set; }
        public string? CategoryName { get; set; } // novo polje
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public Direction Direction { get; set; }
        public string? Description { get; set; }
        public TransactionKind Kind { get; set; }
        public List<TransactionSplitDto> Splits { get; set; } = new();
    }

}
