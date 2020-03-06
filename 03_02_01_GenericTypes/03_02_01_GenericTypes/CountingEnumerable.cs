using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

// generic iterator for numbers 0-9

namespace _03_02_01_GenericTypes
{
    class CountingEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CountingEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class CountingEnumerator : IEnumerator<int>
    {
        int current = -1;

        public int Current 
        {
            get { return current; } 
        }

        object IEnumerator.Current 
        {
            get { return Current; }
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose!");
        }

        public bool MoveNext()
        {
            current++;
            return current < 10;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}
