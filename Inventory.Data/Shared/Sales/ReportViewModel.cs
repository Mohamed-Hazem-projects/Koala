using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Data.Shared.Sales
{
    public class ReportViewModel<T> where T : class
    {
        public string ReportId { get; set; } = Guid.NewGuid().ToString();
        public string ReportName { get; set; }

        public DateTime ReportDate { get; set; } = DateTime.Now;

        public string CompanyLogo { get; set; }
        public string CompanyName { get; set; }

        public List<T> Items { get; set; }
    }
}