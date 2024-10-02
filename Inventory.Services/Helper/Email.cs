using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Services.Helper
{
    public class Email
    {
        public string subject { get; set; }
        public string body { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
