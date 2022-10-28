using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maximum
    {
        public static int MaximumInteger(int first, int second, int third)
       
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            else
            {
                throw new Exception("First, Second, Third are Same");
            }
        }
    }
}
