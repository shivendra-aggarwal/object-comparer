using System;
using System.Linq;

namespace ObjectComparer.Model
{
    public class Student : IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Marks { get; set; }

        /// <summary>
        /// Equal method to compare other object passing as parameter
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Student other)
        {
            if (other == null)
                return false;

            return Id == other.Id
                && string.Equals(Name, other.Name)
                && Marks != null
                && other.Marks != null
                && Marks.Length == other.Marks.Length
                && Marks.OrderBy(id => id).SequenceEqual(other.Marks.OrderBy(id => id));

        }
    }
}
