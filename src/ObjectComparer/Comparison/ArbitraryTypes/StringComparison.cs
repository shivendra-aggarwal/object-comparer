namespace ObjectComparer.Comparison.ArbitraryTypes
{
    /// <summary>
    /// String comparison implementation
    /// </summary>
    public class StringComparison : IComparison<string>
    {
        /// <summary>
        /// this method will compare in between two strings
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public bool IsSimilar(string first, string second)
        {
            return string.Equals(first, second);
        }
    }
}
