using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectEulerInterfaces;
using FibonacciGenerator;

namespace Euler2
{
    public class Euler2Solver : IEulerSolver
    {
        #region IEulerSolver Members
        public object GetSolution(object input)
        {
            if (!(input is long)) throw new InvalidCastException("this method requires a long");

            long rval = 0;

            ISequenceGenerator fibGen = new Fibonacci();

            long[] fibArray = fibGen.UpperBoundedGetSequence((long)input).Cast<long>().ToArray();

            foreach (long l in fibArray)
            {
                if (l % 2 == 0) rval += l;
            }

            return (object)rval;
        }
        #endregion
    }
}

