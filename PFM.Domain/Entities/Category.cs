using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFM.Domain.Entities
{
    public class Category
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string? ParentCode { get; set; }

        [ForeignKey("ParentCode")]
        public Category? ParentCategory { get; set; }

        public ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();

    }
}

