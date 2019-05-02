using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Comparison.ArbitraryTypes
{
    public class StringComparison : IComparison<string>
    {
        public bool IsSimilar(string first, string second)
        {
            return string.Equals(first, second);
        }
    }
}
