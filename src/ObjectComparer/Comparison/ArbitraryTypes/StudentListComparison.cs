using ObjectComparer.Model;
using System.Collections.Generic;

namespace ObjectComparer.Comparison.ArbitraryTypes
{
    /// <summary>
    /// Student list comparison implementation
    /// </summary>
    public class StudentListComparison : IComparison<List<Student>>
    {
        /// <summary>
        /// this method will compare in between two lists of student type
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public bool IsSimilar(List<Student> first, List<Student> second)
        {
            bool result = default(bool);

            if (first == null && second == null)
            {
                return true;
            }

            if (first != null)
            {
                result = first.Count == second.Count;

                for (int i = 0; i < first.Count; i++)
                {
                    if (!first[i].Equals(second[i]))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
