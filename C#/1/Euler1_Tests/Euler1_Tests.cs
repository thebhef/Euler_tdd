using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using ProjectEulerInterfaces;
using Euler1;

namespace Euler1_Tests
{
    /// <summary>
    /// Tests for Project Euler problem 1.
    /// 
    /// "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6,9. 
    /// The sum of the multiples is 23. Find the sum of all multiples of 3 or 5 below 1000"
    /// 
    /// </summary>


    [TestFixture]
    public class Euler1_TestHarness
    {
        [Test]
        public void SolvesExampleProblem()
        {
            IEulerSolver EulerProblem1Solver = new Euler1Solver();

            Assert.AreEqual(23, EulerProblem1Solver.GetSolution((long)10));
        }
    }
}
