using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Comparison
{
    public interface IComparison<T>
    {
        bool IsSimilar(T first, T second);
    }
}
