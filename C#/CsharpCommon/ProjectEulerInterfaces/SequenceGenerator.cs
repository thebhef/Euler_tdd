using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInterfaces
{
    public interface ISequenceGenerator
    {
        object[] GetSequence(long Count);
        object[] GetSequence(object[] Init, long Count);
        object[] UpperBoundedGetSequence(object MaxValue);
        object[] UpperBoundedGetSequence(object[] Init, object MaxValue);
    }
}
