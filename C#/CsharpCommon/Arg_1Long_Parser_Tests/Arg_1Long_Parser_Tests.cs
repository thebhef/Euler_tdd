using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectEulerInterfaces;

using NUnit.Framework;

using Euler_1long_parser;

namespace Arg_1Long_Parser_Tests
{
    [TestFixture]
    public class Arg_1Long_Parser_Tests
    {
        [Test]
        public void ReturnsCorrectValueFromACorrectStringArray()
        {
            string[] args = new string[] { "1234" };

            IEuler1VarParser parser = new Arg_1Long_Parser();

            object returned = parser.ParseStringArray(args);

            Assert.IsTrue(returned is long
                      && ((long)returned == 1234));
        }

        [Test]
        public void ReturnsTooFewArgsFromTooShortArray()
        {
            string[] args = new string[0];

            IEuler1VarParser parser = new Arg_1Long_Parser();

            object returned = parser.ParseStringArray(args);

            Assert.IsTrue(returned is ParserReturnStatus
                      && (ParserReturnStatus)returned == ParserReturnStatus.TooFewArgs);
        }


        [Test]
        public void ReturnsTooManyArgsFromTooShortArray()
        {
            string[] args = new string[2];

            IEuler1VarParser parser = new Arg_1Long_Parser();

            object returned = parser.ParseStringArray(args);

            Assert.IsTrue(returned is ParserReturnStatus
                      && (ParserReturnStatus)returned == ParserReturnStatus.TooManyArgs);
        }


        [Test]
        public void ReturnsInvalidArgFromInvalidArray()
        {
            string[] args = new string[] { "bad value" };

            IEuler1VarParser parser = new Arg_1Long_Parser();

            object returned = parser.ParseStringArray(args);

            Assert.IsTrue(returned is ParserReturnStatus
                      && (ParserReturnStatus)returned == ParserReturnStatus.ArgInvalid);
        }
    }
}
