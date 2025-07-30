using PFM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Domain.Entities
{
    public class Transactions
    {
        public string Id { get; set; }
        public string BeneficiaryName { get; set; }
        public DateTime Date { get; set; }
        public Direction Direction { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }

        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }
        public MccCode? Mcc { get; set; }
        public TransactionKind Kind { get; set; }
        public string? CatCode { get; set; }
        public Category? Category { get; set; }
        public List<TransactionSplit> Splits { get; set; } = new List<TransactionSplit>();

    }
}
