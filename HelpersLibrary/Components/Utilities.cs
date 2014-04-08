using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersLibrary.Components
{
    public class Utilities
    {
        public Utilities()
        {
            prices = new List<Decimal>()
            {
                12.5m,
                13.5m
            };
        }
        //properties
        public bool BoolProp1 { get; set; }

        public String StringProp1 { get; set; }

        public int IntProp1 { get; set; }

        public List<Decimal> prices; 

        public bool DoSomething()
        {
            BoolProp1 = true;
            StringProp1 = "something";

            prices.Add(20);

            return true;
        }

        public List<Decimal> GetPrices()
        {
            return prices;
        }
    }
}
