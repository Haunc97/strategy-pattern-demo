using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternDemo.Models
{
    public class CheckoutModel
    {
        public int SelectedMethod { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal FinalTotal { get; set; }
        public List<ShippingMethod> ShippingMethods { get; set; }
    }
}
