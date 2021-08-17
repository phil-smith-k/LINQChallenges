using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges.Models
{
    public struct Range<T> where T : IComparable<T> 
    {
        public Range(T lowerBound, T upperBound)
        {
            if (lowerBound.CompareTo(upperBound) >= 0)
                throw new ArgumentException("Upper bound must be greater than lower bound.");

            LowerBound = lowerBound;
            UpperBound = upperBound;
        }

        public T LowerBound { get; set; }
        public T UpperBound { get; set; }
    }
}
