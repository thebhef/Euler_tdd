using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;
using ProjectEulerInterfaces;
using Euler2;
using Euler_1long_parser;
using EulerGenericRunner;

namespace Euler2CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var kernel = new Ninject.StandardKernel())
            {
                kernel.Bind<IEulerParser>().To<Arg_1Long_Parser>();
                kernel.Bind<IEulerSolver>().To<Euler2Solver>();

                IEulerRunner runner = new EulerRunner(kernel.Get<IEulerParser>(), kernel.Get<IEulerSolver>());

                Console.WriteLine(runner.SolveEulerProblem(args));
            }
        }
    }
}
