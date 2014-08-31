using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectEulerInterfaces;

namespace Euler_1long_parser
{
    public class Arg_1Long_Parser : IEulerParser
    {
        #region IEuler1VarParser Members

        public object ParseStringArray(string[] args)
        {
            object rval = null;
            long temp;

            if (args.Length > 1)
            {
                rval = ParserReturnStatus.TooManyArgs;
            }
            else if (args.Length < 1)
            {
                rval = ParserReturnStatus.TooFewArgs;
            }
            else if (long.TryParse(args[0], out temp))
            {
                rval = temp;
            }
            else
            {
                rval = ParserReturnStatus.ArgInvalid;
            }

            return rval;
        }

        #endregion
    }
}
