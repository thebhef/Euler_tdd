using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInterfaces
{
    public interface IEulerSolver
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">an object containing the input necessary to solve the problem.</param>
        /// <exception cref="InvalidCastException">
        /// an invalid cast exception will be thrown if input cannot be unboxed as the expected type
        /// </exception>
        /// <returns>
        /// an object containing the solution.
        /// </returns>
        object GetSolution(object input);
    }
}
