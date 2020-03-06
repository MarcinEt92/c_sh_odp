using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _06_02_01_Yield_Iterators
{
    class IterationSample : IEnumerable
    {
        object[] values;
        int startingPoint;

        public IterationSample(object[] values, int startingPoint)
        {
            this.values = values;
            this.startingPoint = startingPoint;
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < values.Length; index++)
            {
                yield return values[(index + startingPoint) % values.Length];
            }
        }
    }
}
