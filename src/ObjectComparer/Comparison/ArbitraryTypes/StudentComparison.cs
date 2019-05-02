using ObjectComparer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Comparison.ArbitraryTypes
{
    public class StudentComparison : IComparison<Student>
    {
        public bool IsSimilar(Student first, Student second)
        {
            return Equals(first, second);
        }
    }
}
