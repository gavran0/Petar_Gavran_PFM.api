using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Domain.Entities
{
    public class CategorizationRule
    {
        public string Title { get; set; }
        public string CatCode { get; set; }
        public string Predicate { get; set; }
    }
}
