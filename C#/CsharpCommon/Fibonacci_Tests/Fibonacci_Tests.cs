using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FibonacciGenerator;

using NUnit.Framework;
using ProjectEulerInterfaces;

namespace Fibonacci_Tests
{
    [TestFixture]
    public class Fibonacci_TestFixture
    {
        [Test]
        public void GeneratesFibonacci()
        {
            ISequenceGenerator f = new Fibonacci();

            //first 21 numbers from wiki fibonacci article
            Assert.AreEqual(new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 
                                         144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 },
                            f.GetSequence(21).Cast<long>().ToArray());
        }

        [Test]
        public void GeneratesFromInitArray()
        {
            Fibonacci f = new Fibonacci();

            //first 21 numbers from wiki fibonacci article
            Assert.AreEqual(new long[] { 8, 13, 21, 34, 55, 89, 
                                         144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 },
                            f.GetSequence((new long[] { 8, 13 }).Cast<object>().ToArray(),
                                            15).Cast<long>().ToArray());
        }


        [Test]
        public void GeneratesFromMaxValue()
        {
            Fibonacci f = new Fibonacci();

            long[] result = f.UpperBoundedGetSequence((long)232).Cast<long>().ToArray();

            Assert.AreEqual(13, result.Length);
            Assert.AreEqual(144, result.Last());
        }


        [Test]
        public void GeneratesFromMaxValueInitialized()
        {
            Fibonacci f = new Fibonacci();

            long[] result = f.UpperBoundedGetSequence((new long[] { 34, 55 }).Cast<object>().ToArray(),
                                                      (long)232).Cast<long>().ToArray();

            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(144, result.Last());
        }


        [Test]
        public void UpperBoundInitArrayOrderDoesNotMatter()
        {
            Fibonacci f = new Fibonacci();

            long[] result = f.UpperBoundedGetSequence((new long[] { 55, 34 }).Cast<object>().ToArray(),
                                                      (long)232).Cast<long>().ToArray();

            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(144, result.Last());
        }


        [Test]
        public void UpperBoundInitBitchesAboutBadInputType()
        {
            Fibonacci f = new Fibonacci();

            Assert.Throws(typeof(InvalidCastException), delegate
            {
                f.UpperBoundedGetSequence((new double[] { 0.0, 1.0 }).Cast<object>().ToArray(),
                    (long)232).Cast<long>().ToArray();
            });
        }


        [Test]
        public void UpperBoundInitBitchesAboutBadInputCount()
        {
            Fibonacci f = new Fibonacci();

            Assert.Throws(typeof(InvalidCastException), delegate
            {
                f.UpperBoundedGetSequence((new long[] { 1 }).Cast<object>().ToArray(),
                    (long)232).Cast<long>().ToArray();
            });

        }


        [Test]
        public void CountInitArrayOrderDoesNotMatter()
        {
            Fibonacci f = new Fibonacci();

            long[] result = f.GetSequence((new long[] { 55, 34 }).Cast<object>().ToArray(),
                                          (long)5).Cast<long>().ToArray();

            Assert.AreEqual(5, result.Length);
            Assert.AreEqual(233, result.Last());
        }


        [Test]
        public void CountInitBitchesAboutBadInputType()
        {
            Fibonacci f = new Fibonacci();

            Assert.Throws(typeof(InvalidCastException), delegate
            {
                f.GetSequence((new double[] { 0.0, 1.0 }).Cast<object>().ToArray(),
                              (long)232).Cast<long>().ToArray();
            });
        }


        [Test]
        public void CountInitBitchesAboutBadInputCount()
        {
            Fibonacci f = new Fibonacci();

            Assert.Throws(typeof(InvalidCastException), delegate
            {
                f.GetSequence((new long[] { 1 }).Cast<object>().ToArray(),
                              (long)232).Cast<long>().ToArray();
            });

        }



    }
}
