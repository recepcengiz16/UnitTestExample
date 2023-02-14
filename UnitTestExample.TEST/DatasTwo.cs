﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.TEST
{
    public class DatasTwo : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, 5, 8 };
            yield return new object[] { 11, 5, 16 };
            yield return new object[] { 23, 2, 25 };
            yield return new object[] { 33, 44, 87 };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
