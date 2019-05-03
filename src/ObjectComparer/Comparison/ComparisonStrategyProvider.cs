using ObjectComparer.Model;
using System;
using System.Collections.Generic;
using ObjectComp = ObjectComparer.Comparison.ArbitraryTypes;

namespace ObjectComparer.Comparison
{
    /// <summary>
    /// this class contains all comparison strategy mapping with respect to its implementation
    /// </summary>
    public static class ComparisonStrategyProvider
    {
        static ComparisonStrategyProvider()
        {
            StrategyMapper = new Dictionary<Type, object>
            {
                {typeof(int), new ObjectComp.IntegerComparison()},
                {typeof(string), new ObjectComp.StringComparison()},
                {typeof(Student), new ObjectComp.StudentComparison()},
                {typeof(List<Student>), new ObjectComp.StudentListComparison()}
            };
        }

        /// <summary>
        /// this readonly property is to get all mappings for different arbitrary type comparison implementation
        /// </summary>
        public static IDictionary<Type, object> StrategyMapper { get; }
    }
}
