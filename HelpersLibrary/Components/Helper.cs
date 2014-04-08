using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpersLibrary.Framework;

namespace HelpersLibrary.Components
{
    public class Helper : IHelper 
    {
        public int Calculate(int a)
        {
            return a + 5;
            //prices.Apply(a => { a = a + 10; });
        }

        public IEnumerable<Decimal> Calculate(IEnumerable<Decimal> collection)
        {
            //collection.Apply(a => { a =  a + 10; });
            var res =  collection.ApplyReturn(a=>a+10);
            //return collection;
            return res;
        }
    }
}
