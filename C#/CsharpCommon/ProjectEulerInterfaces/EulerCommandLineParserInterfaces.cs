using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInterfaces
{
    public interface IEulerParser
    {
        object ParseStringArray(string[] argv);
        string GetUsageString();
        string GetInputFormatString();
    }
}
