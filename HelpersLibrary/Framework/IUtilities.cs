using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelpersLibrary.Framework
{
    public interface IUtilities
    {
        bool BoolProp1 { get; set; }
        string StringProp1 { get; set; }
        int IntProp1 { get; set; }
        IEnumerable<Decimal> prices { get; set; }

        bool DoSomething();
        IEnumerable<Decimal> GetPrices();
    }
}
