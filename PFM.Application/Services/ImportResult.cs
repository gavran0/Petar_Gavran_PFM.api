using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.Services
{
    public class ImportResult
    {
        public int ImportedCount { get; set; }
        public List<string> Errors { get; set; } = new();
        //public List<BusinessErrorResponse> BusinessErrors { get; set; } = new();
    }
}
