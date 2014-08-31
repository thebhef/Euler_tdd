using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;

using ProjectEulerInterfaces;
using Euler_1long_parser;
using Euler1;

namespace EulerGenericRunner
{
    public class EulerRunner : IEulerRunner
    {
        static IEulerParser parser;
        static IEulerSolver solver;

        [Inject]
        public EulerRunner(IEulerParser CmdParser, IEulerSolver ProblemSolver)
        {
            parser = CmdParser;
            solver = ProblemSolver;
        }

        #region IEulerRunner Members

        public string SolveEulerProblem(string[] args)
        {
            string rval = "";
            object parsedArg = parser.ParseStringArray(args);

            if (parsedArg is ParserReturnStatus)
            {
                switch ((ParserReturnStatus)parsedArg)
                {
                    case ParserReturnStatus.ArgInvalid:
                        {
                            rval = "invalid argument: " + parser.GetUsageString();
                            break;
                        }
                    case ParserReturnStatus.TooFewArgs:
                        {
                            rval = "too few arguments";
                            break;
                        }
                    case ParserReturnStatus.TooManyArgs:
                        {
                            rval = "too many arguments";
                            break;
                        }
                }

                rval += "\r\nusage: eulerx.exe " + parser.GetInputFormatString();
            }
            else
            {
                rval = solver.GetSolution(parsedArg).ToString();
            }

            return rval;
        }
        #endregion
    }
}
