namespace ObjectComparer.Comparison
{
    /// <summary>
    /// Generic contract for various arbitrary type comparison implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IComparison<in T>
    {
        bool IsSimilar(T first, T second);
    }
}
