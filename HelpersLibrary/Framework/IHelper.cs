using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersLibrary.Framework
{
    public interface IHelper
    {
        int Calculate(int a);

        IEnumerable<Decimal> Calculate(IEnumerable<Decimal> collection);
    }
}
