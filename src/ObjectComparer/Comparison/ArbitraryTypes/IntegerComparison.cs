namespace ObjectComparer.Comparison.ArbitraryTypes
{
    /// <summary>
    /// Integer comparison implementation
    /// </summary>
    public class IntegerComparison : IComparison<int>
    {
        /// <summary>
        /// this method will compare in between two integers
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public bool IsSimilar(int first, int second)
        {
            return Equals(first, second);
        }
    }
}
