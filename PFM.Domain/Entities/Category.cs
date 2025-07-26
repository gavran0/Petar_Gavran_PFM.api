using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFM.Domain.Entities
{
    public class Category
    {
        [Key]
        public string Code { get; set; }              // Primarni ključ
        public string Name { get; set; }              // Ime kategorije
        public string? ParentCode { get; set; }       // Foreign key ka nadkategoriji (ako postoji)

        [ForeignKey("ParentCode")]
        public Category? ParentCategory { get; set; }

        public ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();

    }
}

