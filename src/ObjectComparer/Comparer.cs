using ObjectComparer.Comparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public static class Comparer
    {
       
        public static bool AreSimilar<T>(T first, T second)
        {
            /// Add your implementation logic here. Feel free to add classes and types as required for your solution.
            /// 
            if (!ComparisonStrategyProvider.StrategyMapper.ContainsKey(typeof(T)))
            {
                throw new Exception("Given type doesn't have support to compare");
            }

            IComparison<T> objComparison = ComparisonStrategyProvider.StrategyMapper[typeof(T)] as IComparison<T>;
            return objComparison.IsSimilar(first, second);
        }
    }
}
