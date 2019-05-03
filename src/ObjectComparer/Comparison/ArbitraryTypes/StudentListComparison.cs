using ObjectComparer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Comparison.ArbitraryTypes
{
    public class StudentListComparison : IComparison<List<Student>>
    {
        public bool IsSimilar(List<Student> first, List<Student> second)
        {
            bool result = default(bool);

            if (first == null && second == null)
            {
                return true;
            }

            result = first.Count == second.Count;

            for (int i = 0; i < first.Count; i++)
            {
                if (!first[i].Equals(second[i]))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
