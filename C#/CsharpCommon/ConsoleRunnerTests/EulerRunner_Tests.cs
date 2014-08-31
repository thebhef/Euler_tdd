using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectEulerInterfaces;
using EulerGenericRunner;

using NUnit.Framework;
using Moq;

namespace EulerGenericRunner_Tests
{
    [TestFixture]
    public class EulerRunner_Tests
    {
        [Test]
        public void CallsParserAndSolverCorrectly()
        {
            var parser = new Mock<IEulerParser>();
            parser.Setup(m => m.ParseStringArray(new string[] { "1234" })).Returns(1234);

            var solver = new Mock<IEulerSolver>();
            solver.Setup(m => m.GetSolution(1234)).Returns(4);

            EulerRunner er = new EulerRunner(parser.Object, solver.Object);

            Assert.AreEqual("4", er.SolveEulerProblem(new string[] { "1234" }));

        }

        [Test]
        public void HandlesInvalidArgErrorCorrectly()
        {
            var parser = new Mock<IEulerParser>();
            parser.Setup(m => m.ParseStringArray(new string[] { "1234" })).Returns(ParserReturnStatus.ArgInvalid);
            parser.Setup(m => m.GetInputFormatString()).Returns("input format");
            parser.Setup(m => m.GetUsageString()).Returns("usage");

            var solver = new Mock<IEulerSolver>();
            solver.Setup(m => m.GetSolution(1234)).Returns(4);

            EulerRunner er = new EulerRunner(parser.Object, solver.Object);

            Assert.AreEqual("invalid argument: usage\r\nusage: eulerx.exe input format",
                            er.SolveEulerProblem(new string[] { "1234" }));
        }

        [Test]
        public void HandlesTooFewArgsErrorCorrectly()
        {
            var parser = new Mock<IEulerParser>();
            parser.Setup(m => m.ParseStringArray(new string[] { "1234" })).Returns(ParserReturnStatus.TooFewArgs);
            parser.Setup(m => m.GetInputFormatString()).Returns("input format");
            parser.Setup(m => m.GetUsageString()).Returns("usage");

            var solver = new Mock<IEulerSolver>();
            solver.Setup(m => m.GetSolution(1234)).Returns(4);

            EulerRunner er = new EulerRunner(parser.Object, solver.Object);

            Assert.AreEqual("too few arguments\r\nusage: eulerx.exe input format",
                            er.SolveEulerProblem(new string[] { "1234" }));
        }


        [Test]
        public void HandlesTooManyArgsErrorCorrectly()
        {
            var parser = new Mock<IEulerParser>();
            parser.Setup(m => m.ParseStringArray(new string[] { "1234" })).Returns(ParserReturnStatus.TooManyArgs);
            parser.Setup(m => m.GetInputFormatString()).Returns("input format");
            parser.Setup(m => m.GetUsageString()).Returns("usage");

            var solver = new Mock<IEulerSolver>();
            solver.Setup(m => m.GetSolution(1234)).Returns(4);

            EulerRunner er = new EulerRunner(parser.Object, solver.Object);

            Assert.AreEqual("too many arguments\r\nusage: eulerx.exe input format",
                            er.SolveEulerProblem(new string[] { "1234" }));
        }

    }
}