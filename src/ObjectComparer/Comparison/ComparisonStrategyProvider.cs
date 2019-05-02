using ObjectComp = ObjectComparer.Comparison.ArbitraryTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectComparer.Model;

namespace ObjectComparer.Comparison
{
    public static class ComparisonStrategyProvider
    {
        private static IDictionary<Type, object> strategyMapper;

        static ComparisonStrategyProvider()
        {
            strategyMapper = new Dictionary<Type, object>();
            StrategyMapper.Add(typeof(int), new ObjectComp.IntegerComparison());
            StrategyMapper.Add(typeof(string), new ObjectComp.StringComparison());
            StrategyMapper.Add(typeof(Student), new ObjectComp.StudentComparison());
            StrategyMapper.Add(typeof(List<Student>), new ObjectComp.StudentListComparison());
        }

        public static IDictionary<Type, object> StrategyMapper { get => strategyMapper; }
    }
}
