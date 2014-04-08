using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpersLibrary.Framework;

namespace HelpersLibrary.Components
{
    public class Utilities : IUtilities
    {
        private IHelper helper;

        public Utilities()
        {
            if (helper == null)
            {
                helper = new Helper();
            }
        }

        public Utilities(IHelper helper)
        {
            this.helper = helper;
            prices = new List<Decimal>()
            {
                12.5m,
                13.5m
            };
        }

        //properties
        public bool BoolProp1 { get; set; }

        public string StringProp1 { get; set; }

        public int IntProp1 { get; set; }

        public IEnumerable<decimal> prices { get; set; } 

        public bool DoSomething()
        {
            BoolProp1 = true;
            StringProp1 = "something";

            return true;
        }

        public IEnumerable<Decimal> GetPrices()
        {
            //var res = helper.Calculate(prices);
            //return res.ToList();
            helper.CheckIfArgIsNull("helper");
            return helper.Calculate(prices);
        }
    }
}
