using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CreateUseTypes.Auxiliar.ExtensionMethods
{
    public static class MyExtensions
    {
        public static int LineCount(this String str)
        {
            return str.Split(new char[] { '\n' },
                                    StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
