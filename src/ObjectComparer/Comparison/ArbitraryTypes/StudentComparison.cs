using ObjectComparer.Model;

namespace ObjectComparer.Comparison.ArbitraryTypes
{
    /// <summary>
    /// Student complex type comparison implementation
    /// </summary>
    public class StudentComparison : IComparison<Student>
    {
        /// <summary>
        /// this method will compare in between two student object
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public bool IsSimilar(Student first, Student second)
        {
            return first.Equals(second);
        }
    }
}
