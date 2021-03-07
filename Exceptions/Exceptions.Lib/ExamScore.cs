using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Lib
{
    public class TriangleTest
    {
        readonly double _total;

        public TriangleTest(double angle1, double angle2, double angle3)
        {
            if (angle1 <= 0 || angle2 <= 0 || angle3 <= 0)
                throw new TriangleTestException(2, "Must have positive, non-zero angles");

            _total = angle1 + angle2 + angle3;
        }

        public double totalangle
        {
            get
            {
                return _total;
            }
        }
    }
}
