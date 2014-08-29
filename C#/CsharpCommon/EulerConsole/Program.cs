using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectEulerInterfaces;
using Euler_1long_parser;
using Euler1;

namespace EulerConsole
{
    class Program
    {
        //TODO: update with ninject and add test cases with mocked objects.

        static IEuler1VarParser parser;
        static IEulerSolver solver;

        static void Main(string[] args)
        {
            parser = new Arg_1Long_Parser();
            solver = new Euler1Solver();

            string rval = "";
            object parsedArg = parser.ParseStringArray(args);

            if (parsedArg is ParserReturnStatus)
            {
                switch ((ParserReturnStatus)parsedArg)
                {
                    case ParserReturnStatus.ArgInvalid:
                        {
                            rval = "argument not a natural number";
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

                rval += "\r\nusage: euler1 <upper bound>";
            }
            else
            {
                rval = solver.GetSolution(parsedArg).ToString();
            }

            Console.WriteLine(rval);
            Console.ReadLine();
        }
    }
}
