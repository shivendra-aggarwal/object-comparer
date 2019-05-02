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
            throw new NotImplementedException();
        }
    }
}
