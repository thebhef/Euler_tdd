using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectEulerInterfaces;

namespace PrimeNumberGenerator
{

    /// <summary>
    /// Sieve of Eratosthenes + 2 3 5 wheel
    /// 
    /// 
    /// TODO:
    /// Does ISequenceGenerator work for this? Maybe it's not generic enough? 
    /// What other kinds of things would be more like this prime number gen?
    /// How will I test the wheel, or should it be separate?
    /// 
    /// </summary>

    public class PrimeGenerator : ISequenceGenerator
    {
        #region ISequenceGenerator Members
        public object[] GetSequence(long Count)
        {
            throw new NotImplementedException();
        }

        public object[] GetSequence(object[] Init, long Count)
        {
            throw new NotImplementedException();
        }

        public object[] UpperBoundedGetSequence(object MaxValue)
        {
            throw new NotImplementedException();
        }

        public object[] UpperBoundedGetSequence(object[] Init, object MaxValue)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
