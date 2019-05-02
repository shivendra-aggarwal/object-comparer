using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Comparison.ArbitraryTypes
{
    public class IntegerComparison : IComparison<int>
    {
        public bool IsSimilar(int first, int second)
        {
            return int.Equals(first, second);
        }
    }
}
