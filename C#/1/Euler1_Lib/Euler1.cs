using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;

using ProjectEulerInterfaces;

namespace Euler1
{
    public class Euler1Solver : IEulerSolver
    {
        [Inject]
        public Euler1Solver()
        {
        }

        #region IUpperBoundNaturalNumberEulerProblem Members
        public object GetSolution(object Input)
        {
            if (!(Input is long)) throw new InvalidCastException("this method requires a long");

            long rval = 0;

            for (int i = 1; i < (long)Input; ++i)
            {
                if (i % 3.0 == 0 || i % 5.0 == 0)
                {
                    rval += i;
                }
            }

            return rval;
        }
        #endregion
    }
}
