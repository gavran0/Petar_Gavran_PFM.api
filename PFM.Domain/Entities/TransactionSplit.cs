using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Domain.Entities
{
    public class TransactionSplit
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string TransactionId { get; set; }

        [ForeignKey("TransactionId")]
        public Transactions Transaction { get; set; }

        [Required]
        public string CatCode { get; set; }

        [ForeignKey("CatCode")]
        public Category Category { get; set; }

        [Required]
        public double Amount { get; set; }
    }

}
