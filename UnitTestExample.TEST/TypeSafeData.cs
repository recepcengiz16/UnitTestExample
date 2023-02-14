using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.TEST
{
    public class TypeSafeData : TheoryData<int, int, int>
    {
        public TypeSafeData()
        {
            Add(3, 5, 8);
            Add(11, 5, 16);
            Add(23, 2, 25);
            Add(33, 44, 87);
        }
    }
}
