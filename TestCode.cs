using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TestCode
    {
        public static void TestCase1Integer()
        {
            int result = Maximum.MaximumInteger(10, 5, 6);
            Console.WriteLine("\nIn First Case Maximum Number is " + result);
        }

        public static void TestCase2Integer()
        {
            int result = Maximum.MaximumInteger(10, 15, 6);
            Console.WriteLine("\nIn Second case Maximum Number is " + result);
        }

        public static void TestCase3Integer()
        {
            int result = Maximum.MaximumInteger(10, 5, 16);
            Console.WriteLine("\nIn Third Case Maximum Number is " + result);
        }

    }
}
