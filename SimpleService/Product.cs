using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleService
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? CodeName { get; set; }
        public string? Description { get; set; }
        public int Category { get; set; }
        public string? Color { get; set; }
        public DateTime ProductionDate { get; set; }
    }
}
