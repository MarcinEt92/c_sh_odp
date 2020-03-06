using System.Collections;

namespace _06_01_01_Iterators
{
    public class IterationSampleCollection : IEnumerable
    {
        public object[] values;
        public int startingPoint;

        public IterationSampleCollection(object[] values, int startingPoint)
        {
            this.values = values;
            this.startingPoint = startingPoint;
        }

        public IEnumerator GetEnumerator()
        {
            // C# 1
            //return new IterationSampleIterator(this);

            // implementation ic C#2, this code below replaces entire Class IterationSampleIterator
            for (int index = 0; index < values.Length; index++)
            {
                yield return values[(index + startingPoint) % values.Length];
            }

        }
    }
}