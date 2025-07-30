using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFM.Domain.Enums;

namespace PFM.Application.DTO
{
    public class SpendingAnalyticsItem
    {
        public string CategoryCode { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public double TotalAmount { get; set; }
        public Direction? Direction { get; set; }
    }

}
