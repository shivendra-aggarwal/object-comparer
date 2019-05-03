using ObjectComparer.Comparison;
using System;

namespace ObjectComparer
{
    public static class Comparer
    {
       
        public static bool AreSimilar<T>(T first, T second)
        {
            if (!ComparisonStrategyProvider.StrategyMapper.ContainsKey(typeof(T)))
            {
                throw new Exception("Given type doesn't have support to compare");
            }

            return ComparisonStrategyProvider.StrategyMapper[typeof(T)] is IComparison<T> objComparison && objComparison.IsSimilar(first, second);
        }
    }
}
