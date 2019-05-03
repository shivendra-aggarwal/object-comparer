using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Model
{
    public class Student : IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Marks { get; set; }

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
