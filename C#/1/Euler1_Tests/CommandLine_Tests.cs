using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler1;
using ProjectEulerInterfaces;
using NUnit.Framework;

namespace Euler1_Tests
{
    [TestFixture]
    class CommandLine_Tests
    {
        [Test]
        void SolvesExampleProblemWhenPassedString()
        {
            string[] InputString = new string[] { "", "" };
            IEuler1VarParser Parser = new EulerSingleLongParser();
        }
    }
}
