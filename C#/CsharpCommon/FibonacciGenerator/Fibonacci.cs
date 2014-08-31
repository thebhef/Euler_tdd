using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectEulerInterfaces;

namespace FibonacciGenerator
{
    public class Fibonacci : ISequenceGenerator
    {
        public Fibonacci()
        {
        }

        #region ISequenceGenerator Members
        public object[] GetSequence(long Count)
        {
            return GetSequence((new long[] { 0, 1 }).Cast<object>().ToArray(), Count);
        }


        public object[] GetSequence(object[] Init, long Count)
        {
            if (Init.Length != 2
             || !(Init[0] is long)
             || !(Init[1] is long)) throw new InvalidCastException("init must be an array of two longs.");

            long[] rval = new long[Count];

            rval[0] = Math.Min((long)Init[0], (long)Init[1]);
            rval[1] = Math.Max((long)Init[0], (long)Init[1]);

            return GenerateFromInitializedArray(long.MinValue, rval);
        }


        public object[] UpperBoundedGetSequence(object MaxValue)
        {
            return UpperBoundedGetSequence((new long[] { 0, 1 }).Cast<object>().ToArray(), MaxValue);
        }


        public object[] UpperBoundedGetSequence(object[] Init, object MaxValue)
        {
            if (!(MaxValue is long)) throw new InvalidCastException("MaxValue needs to be a long");

            if (Init.Length != 2
             || !(Init[0] is long)
             || !(Init[1] is long)) throw new InvalidCastException("init must be an array of two longs.");

            long[] rval = new long[30];

            rval[0] = Math.Min((long)Init[0], (long)Init[1]);
            rval[1] = Math.Max((long)Init[0], (long)Init[1]);

            return GenerateFromInitializedArray((long)MaxValue, rval);
        }
        #endregion


        private static object[] GenerateFromInitializedArray(long MaxValue, long[] rval)
        {
            for (int i = 2; (i < rval.Length && MaxValue == long.MinValue) || rval[i - 1] < MaxValue; ++i)
            {
                //grow the array if we're looking for the max value and we haven't found it
                if (MaxValue > 0
                 && i == rval.Length - 1
                 && rval[i - 1] < MaxValue)
                {
                    Array.Resize<long>(ref rval, rval.Length * 2);
                }

                rval[i] = rval[i - 1] + rval[i - 2];

                if (MaxValue > 0 && rval[i] > MaxValue)
                {
                    rval = rval.Take<long>(i).ToArray();
                    break;
                }
            }

            return rval.Cast<object>().ToArray();
        }
    }
}
