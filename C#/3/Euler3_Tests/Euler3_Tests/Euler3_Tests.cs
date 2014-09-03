using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Euler3;
using NUnit.Framework;
using ProjectEulerInterfaces;

namespace Euler3_Tests
{
    /// <summary>
    /// Euler 3 tests.
    /// 
    /// The Problem:
    /// 
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// 
    /// </summary>

    [TestFixture]
    public class Euler3_TestFixture
    {
        [Test]
        public void ReturnsPrimeFactorsAsExpected()
        {
            IEulerSolver solver = new Euler3Solver();

            string solution = solver.GetSolution((long)13195).ToString();

            Assert.AreEqual("5,7,13,29", solution);
        }
    }
}
