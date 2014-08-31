using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EulerGenericRunner;
using ProjectEulerInterfaces;
using Euler1;
using Euler_1long_parser;

using Ninject;

namespace ConsoleProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var kernel = new StandardKernel())
            {
                kernel.Bind<IEulerParser>().To<Arg_1Long_Parser>();
                kernel.Bind<IEulerSolver>().To<Euler1Solver>();

                EulerRunner runner = new EulerRunner(kernel.Get<IEulerParser>(), kernel.Get<IEulerSolver>());
                Console.WriteLine(runner.SolveEulerProblem(args));
            }
        }
    }
}
