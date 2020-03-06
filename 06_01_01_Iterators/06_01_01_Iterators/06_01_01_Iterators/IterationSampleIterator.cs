using System;
using System.Collections;

namespace _06_01_01_Iterators
{
    class IterationSampleIterator : IEnumerator
    {
        private IterationSampleCollection parent;
        int position;

        public IterationSampleIterator(IterationSampleCollection parent)
        {
            this.parent = parent;
            this.position = -1;
        }

        public object Current
        {
            get
            {
                if(position == -1 || position == parent.values.Length)
                {
                    throw new InvalidOperationException();
                }
                int index = position + parent.startingPoint;
                index = index % parent.values.Length;
                return parent.values[index];
            }
        }

        public bool MoveNext()
        {
            if (position != parent.values.Length)
            {
                position++;
            }
            return position < parent.values.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}