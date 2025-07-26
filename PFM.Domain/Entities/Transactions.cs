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
        public string Id { get; set; }                         // "abc123"
        public string BeneficiaryName { get; set; }            // "Shell"
        public DateTime Date { get; set; }                     // "2023-07-01"
        public Direction Direction { get; set; }                  // "debit" / "credit"
        public double Amount { get; set; }                    // 50.00
        public string Description { get; set; }              // "Fuel payment"

        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }                   // "USD" or "RSD"
        public MccCode? Mcc { get; set; }                           // Merchant Category Code (npr. 5811)
        public TransactionKind Kind { get; set; }                       // "payment", "fee", "transfer", itd.
        public string? CatCode { get; set; }
        public Category? Category { get; set; }
        public List<TransactionSplit> Splits { get; set; } = new List<TransactionSplit>();

    }
}
