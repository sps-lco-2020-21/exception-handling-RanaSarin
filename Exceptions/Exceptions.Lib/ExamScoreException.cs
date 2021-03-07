using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Lib
{
    public class TriangleTestException : Exception
    {
        readonly int _codeNumber;

        public TriangleTestException(int codeNumber, string msg) : base(msg)
        {
            _codeNumber = codeNumber;
        }

        public override string Message
        {
            get
            {
                return string.Format("Code [{0}]: {1}", _codeNumber, base.Message);
            }
        }
    }
}
